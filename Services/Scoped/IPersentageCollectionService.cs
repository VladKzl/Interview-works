namespace UserStatistics.Services.Singletons
{
    public interface IPersentageCollectionService
    {
        Task<int> GetPersent(Guid queryId);
        Task Update(Guid queryId, int percent);
    }
}
