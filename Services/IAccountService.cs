using ZenCityHallSpendingApi.Dtos;
using ZenCityHallSpendingApi.Models;

namespace ZenCityHallSpendingApi.Services
{
    public interface IAccountService
    {
        UserReadDto Register(UserCreateDto userDto);
        User Authenticate(UserAuthenticateDto userDto);
    }
}
