namespace UserStatistics.Shared.DataTransferObjects
{
    public record GetUserStatisticsReturnDto(Guid query, int percent, int result);
}
