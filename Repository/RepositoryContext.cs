using Microsoft.EntityFrameworkCore;
using UserStatistics.Entities.Models;
using UserStatistics.Repository.Configuration;

namespace UserStatistics.Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
        : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserStatisticsConfiguration());
        }
        public DbSet<Statistics> UserStatistics { get; set; }
    }
}
