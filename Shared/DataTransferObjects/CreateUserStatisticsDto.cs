using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserStatistics.Shared.DataTransferObjects
{
    public record CreateUserStatisticsDto(Guid userId, int From, int To);
}
