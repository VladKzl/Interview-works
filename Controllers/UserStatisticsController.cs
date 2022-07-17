using CompanyEmployees.ActionFilters;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using UserStatistics.Shared.DataTransferObjects;

namespace UserStatistics.Controllers
{
    [Route("report")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IServiceManager service;
        public ReportController(IServiceManager service) => 
        this.service = service;

        [HttpGet("info/{queryId:guid}", Name = "GetUserStatistics")]
        public async Task<IActionResult> GetUserStatistics(Guid queryId)
        {
            var userStatistics = await service.UserStatisticsService.GetUserStatisticsByQueryIdAsync
                (queryId, false);
            return Ok(userStatistics);
        }
        [HttpPost("user_statistics/{id}")] // id не нужно, но без параметра не работает...
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateUserStatistics([FromBody] CreateUserStatisticsDto userStatistics)
        {
            var queryId = await service.UserStatisticsService.CreateUserStatisticsAsync(userStatistics);
            return CreatedAtRoute("GetUserStatistics", new { queryId }, new { queryId });
        }
    }
}
