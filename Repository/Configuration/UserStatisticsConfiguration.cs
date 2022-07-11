using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserStatistics.Entities.Models;

namespace UserStatistics.Repository.Configuration
{
    public class UserStatisticsConfiguration : IEntityTypeConfiguration<Statistics>
    {
        public void Configure(EntityTypeBuilder<Statistics> builder)
        {
            builder.HasData
            (
            new Statistics
            {
                Id = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
                CountSignIn = 12,
            },
            new Statistics
            {
                Id = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
                CountSignIn = 8,
            },
            new Statistics
            {
                Id = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
                CountSignIn = 2,
            }
            );
        }
    }
}
