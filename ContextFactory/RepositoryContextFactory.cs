using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using UserStatistics.Repository;

namespace UserStatistics.ContextFactory
{
    public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
    {
        private IConfigurationRoot configuration;
        public RepositoryContextFactory(IConfigurationRoot configuration)
        {
            this.configuration = configuration;
        }
        public RepositoryContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<RepositoryContext>().UseSqlServer
                (configuration.GetConnectionString("sqlConnection"),
            b => b.MigrationsAssembly("UserStatistics"));
            return new RepositoryContext(builder.Options);
        }
    }
}
