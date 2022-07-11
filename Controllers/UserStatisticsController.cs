using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using UserStatistics.Shared.DataTransferObjects;

namespace UserStatistics.Controllers
{
    [Route("api/report")]
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
        [HttpPost("user_statistics/{id}")]
        public async Task<IActionResult> CreateUserStatistics([FromBody] CreateUserStatisticsDto userStatistics)
        {
            var queryId = await service.UserStatisticsService.CreateUserStatisticsAsync(userStatistics);
            return CreatedAtRoute("GetUserStatistics", new { queryId }, new { queryId });
        }
/*        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteUserStatistics(Guid id)
        {
            await service.CompanyService.DeleteCompanyAsync(id, trackChanges: false);
            return NoContent();
        }
        [HttpPut("{id:guid}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateUserStatistics(Guid id, [FromBody] CompanyForUpdateDto
        company)
        {
            await service.CompanyService.UpdateCompanyAsync(id, company, trackChanges:
            true);
            return NoContent();
        }*/
    }
}
