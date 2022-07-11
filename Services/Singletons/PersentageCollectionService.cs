using UserStatistics.Contracts;

namespace UserStatistics.Services.Singletons
{
    public class PersentageCollectionService
    {
        private Dictionary<Guid, int> percentage = new Dictionary<Guid, int>();
        public int GetPersent(Guid queryId)
        {
            int value;
            if (percentage.TryGetValue(queryId, out value))
            {
                return value;
            }
            else
            {
                return 0;
            }
        }
        public void Update(Guid queryId, int percent)
        {
            int value;
            if(percentage.TryGetValue(queryId, out value))
            {
                percentage[queryId] = percent;
            }
            else
            {
                percentage.Add(queryId, percent);
            }
        }
        public void Delete(Guid queryId)
        {
            percentage.Remove(queryId);
        }
    }
}
