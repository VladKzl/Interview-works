using UserStatistics.Contracts;

namespace UserStatistics.Repository
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext repositoryContext;
        private readonly Lazy<IUserStatisticsRepository> UserStatisticsRepository;
        public RepositoryManager(RepositoryContext repositoryContext)
        {
            this.repositoryContext = repositoryContext;
            UserStatisticsRepository = new Lazy<IUserStatisticsRepository>(() =>
            new UserStatisticsRepository(repositoryContext));
        }
        public IUserStatisticsRepository UserStatistics => UserStatisticsRepository.Value;
        public void Save() => repositoryContext.SaveChanges();
        public async Task SaveAsync() => await repositoryContext.SaveChangesAsync();
    }
}
