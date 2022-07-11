using UserStatistics.Entities.Models;
using Service.Contracts;
using System.Diagnostics;
using UserStatistics.Contracts;
using Microsoft.AspNetCore.Mvc;
using UserStatistics.Shared.DataTransferObjects;
using UserStatistics.Services.Singletons;

namespace UserStatistics.Service
{
    internal sealed class UserStatisticsService : IUserStatisticsService
    {
        private readonly IRepositoryManager repository;
        private PersentageCollectionService percentageCollection;
        private int TimeLimit { get; set; }
        public UserStatisticsService(IRepositoryManager repository,
         IConfigurationRoot configuration, PersentageCollectionService percentageCollection)
        {
            this.repository = repository;
            this.percentageCollection = percentageCollection;
            TimeLimit = int.Parse(configuration["TimeLimit"]);
            /*this.logger = logger;*/
            /*this.mapper = mapper;*/
        }
        public async Task<JsonResult> GetUserStatisticsByQueryIdAsync
        (Guid queryId, bool trackChanges)
        {
            Statistics user = await repository.UserStatistics.GetUserStatisticsByQueryIdAsync
                (queryId, trackChanges);
            if(user == null)
                throw new Exception();

            int percent = percentageCollection.GetPersent(queryId);
            if (percent < 100)
            {
                return new JsonResult(new
                {
                    query = user.Id,
                    percent = percent,
                    result = "null"
                });
            }
            return new JsonResult(new
            {
                query = user.Id,
                percent = percent,
                result = new
                {
                    user_id = user.UserId,
                    count_sign_in = user.CountSignIn
                }
            });
        }
        public async Task<Guid> CreateUserStatisticsAsync(CreateUserStatisticsDto userStatistics)
        {
            var resultUser = await GetUserStatisticsIfExists(userStatistics.userId, false);
            if (resultUser == null)
            {
                Statistics newUser = new Statistics()
                { UserId = userStatistics.userId, CountSignIn = userStatistics.From };
                repository.UserStatistics.CreateUserStatistics(newUser);
                await repository.SaveAsync();
                Statistics user = await repository.UserStatistics.GetUserStatisticsByIdAsync
                (userStatistics.userId, false);
                Task.Run(async () => await ContinueUpdateUserStatisticsAsync(userStatistics)); // Не жду. Обновляется в фоне.
                return user.Id;
            }
            return resultUser.Id;
        }
        public async Task<Statistics> GetUserStatisticsIfExists(Guid userId, bool trackChanges)
        {
            var userStatistics = await repository.UserStatistics.GetUserStatisticsByIdAsync(userId, trackChanges);
            if (userStatistics is null)
            {
                return null;
            }
            return userStatistics;
        }
        public async Task ContinueUpdateUserStatisticsAsync(CreateUserStatisticsDto userStatistics)
        {
            Stopwatch timer = Stopwatch.StartNew();
            TimeSpan appTimeLimit = TimeSpan.FromSeconds(TimeLimit);

            Statistics user = await repository.UserStatistics.GetUserStatisticsByIdAsync
            (userStatistics.userId, true);
            int addSessions = userStatistics.To - userStatistics.From;
            int signInCounter = 0;

            do // Обновляем репозиторий не меньше userStatistics.To раз и appTimeLimit сек.
            {
                await Task.Delay(appTimeLimit/addSessions);
                user.CountSignIn += 1;
                signInCounter += 1;
                repository.UserStatistics.UpdateUserStatistics(user);
                await repository.SaveAsync();
                UpdateCompletionPercentage(timer,user.Id);
            }
            while(timer.Elapsed < appTimeLimit && signInCounter != addSessions);
            timer.Stop();
        }
        public void UpdateCompletionPercentage(Stopwatch timer, Guid queryId)
        {
            int elapsed = (int)timer.Elapsed.TotalSeconds;
            int percent = 100 * elapsed / TimeLimit;
            percentageCollection.Update(queryId, percent);
        }
        /*        public async Task UpdateUserStatisticsAsync(UserStatistics userStatistics, bool trackChanges)
                {
                    await repository.SaveAsync();
                }*/

        /*        public async Task DeleteCompanyAsync(Guid companyId, bool trackChanges)
                {
                    var company = await GetUserStatisticsAndCheckIfItExists(companyId, trackChanges);
                    repository.UserStatistics.DeleteUserStatistics(company);
                    await repository.SaveAsync();
                }*/
    }
}