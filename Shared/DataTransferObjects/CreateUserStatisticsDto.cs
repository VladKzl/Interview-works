using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserStatistics.Shared.DataTransferObjects
{
    public record CreateUserStatisticsDto
    {
        [Required(ErrorMessage = "UserId is a required field.")]
        public Guid UserId { get; init; }
        [Required(ErrorMessage = "From is a required field.")]
        [Range(0, int.MaxValue, ErrorMessage = "From is required and it can't be less than 0")]
        public int From { get; init; }
        [Required(ErrorMessage = "To is a required field.")]
        [Range(1, int.MaxValue, ErrorMessage = "To is required and it can't be less than 1")]
        public int To { get; init; }
    }
}
