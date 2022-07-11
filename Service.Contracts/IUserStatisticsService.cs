using Microsoft.AspNetCore.Mvc;
using UserStatistics.Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface IUserStatisticsService
    {
        Task<JsonResult> GetUserStatisticsByQueryIdAsync
        (Guid queryId, bool trackChanges);
        Task<Guid> CreateUserStatisticsAsync(CreateUserStatisticsDto userStatistics);
/*        Task DeleteUserStatisticsAsync(Guid companyId, bool trackChanges);
        Task UpdateUserStatisticsAsync(Guid companyid, CompanyForUpdateDto companyForUpdate,
        bool trackChanges);*/
    }
}