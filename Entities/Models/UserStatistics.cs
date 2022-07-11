using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserStatistics.Entities.Models
{
    public class Statistics
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "UserId is a required field.")]
        public Guid UserId { get; set; }
        [Required(ErrorMessage = "CountSignIn is a required field.")]
        public int CountSignIn { get; set; }
    }
}
