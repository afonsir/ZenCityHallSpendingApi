using AutoMapper;
using ZenCityHallSpendingApi.Dtos;
using ZenCityHallSpendingApi.Models;

namespace ZenCityHallSpendingApi.Profiles
{
    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            CreateMap<User, UserReadDto>();
            CreateMap<UserCreateDto, User>();
        }
    }
}
