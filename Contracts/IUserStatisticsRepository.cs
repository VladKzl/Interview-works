using UserStatistics.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserStatistics.Contracts
{
    public interface IUserStatisticsRepository
    {
        Task<Statistics> GetUserStatisticsByQueryIdAsync
        (Guid queryId, bool trackChanges);
        Task<Statistics> GetUserStatisticsByIdAsync
        (Guid userId, bool trackChanges);
        void CreateUserStatistics(Statistics company);
        void DeleteUserStatistics(Statistics company);
        void UpdateUserStatistics(Statistics company);
    }
}
 