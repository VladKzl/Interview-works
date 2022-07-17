using AutoMapper;
using UserStatistics.Entities.Models;
using UserStatistics.Shared.DataTransferObjects;

namespace CompanyEmployees
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Statistics, CreateUserStatisticsDto>().ReverseMap();
        }
    }
}
