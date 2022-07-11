using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserStatistics.Contracts
{
    public interface IRepositoryManager
    {
        IUserStatisticsRepository UserStatistics { get; }
        void Save();
        Task SaveAsync();
    }
}
