using UserStatistics.Contracts;
using UserStatistics.Entities.Models;

namespace UserStatistics.Services.Singletons
{
    public class PersentageCollectionService : IPersentageCollectionService
    {
        private readonly IRepositoryManager repository;
        public PersentageCollectionService(IRepositoryManager repository)
        {
            this.repository = repository;
        }
        public async Task<int> GetPersent(Guid queryId)
        {
            Statistics userByQuery = await repository.UserStatistics.GetUserStatisticsByQueryIdAsync(queryId, false);
            return userByQuery.Persentage;
        }
        public async Task Update(Guid queryId, int percent)
        {
            Statistics userByQuery = await repository.UserStatistics.GetUserStatisticsByQueryIdAsync(queryId, true);
            userByQuery.Persentage = percent;
            await repository.SaveAsync();
        }
    }
}
