using AutoMapper;
using Dtos;
using ZenCityHallSpendingApi.Models;

namespace Profiles
{
    public class EmpenhosProfile : Profile
    {
        public EmpenhosProfile()
        {
            CreateMap<Empenho, EmpenhoTotalValueDto>();
        }
        
    }
}