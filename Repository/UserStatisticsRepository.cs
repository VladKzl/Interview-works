using Microsoft.EntityFrameworkCore;
using UserStatistics.Contracts;
using UserStatistics.Entities.Models;

namespace UserStatistics.Repository
{
    public class UserStatisticsRepository : RepositoryBase<Statistics>, IUserStatisticsRepository
    {
        public UserStatisticsRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {
        }
        public async Task<Statistics> GetUserStatisticsByQueryIdAsync
        (Guid queryId, bool trackChanges) =>
            await FindByCondition(x => x.Id == queryId, trackChanges).SingleOrDefaultAsync();
        public async Task<Statistics> GetUserStatisticsByIdAsync
        (Guid userId, bool trackChanges) =>
            await FindByCondition(x => x.UserId == userId, trackChanges).SingleOrDefaultAsync();
        public void CreateUserStatistics(Statistics company) => Create(company);
        public void UpdateUserStatistics(Statistics company) => Update(company);

        public void DeleteUserStatistics(Statistics company) => Delete(company);
    }
}
