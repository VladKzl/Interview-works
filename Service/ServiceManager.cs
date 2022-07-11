using UserStatistics.Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserStatistics.Services.Singletons;

namespace UserStatistics.Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IUserStatisticsService> userStatisticsService;
        public ServiceManager(IRepositoryManager repository,
         IConfigurationRoot configuration, PersentageCollectionService percentageCollection)
        {
            userStatisticsService = new Lazy<IUserStatisticsService>(() =>
            new UserStatisticsService(repository, configuration, percentageCollection));
        }
        public IUserStatisticsService UserStatisticsService => userStatisticsService.Value;
    }
}
