using AutoMapper;
using ZenCityHallSpendingApi.Dtos;
using ZenCityHallSpendingApi.Models;
using ZenCityHallSpendingApi.Repositories;

namespace ZenCityHallSpendingApi.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public AccountService(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public User Authenticate(UserAuthenticateDto userDto)
        {
            var userModel = _repository.FindByEmail(userDto.Email);

            if (userModel != null && BCrypt.Net.BCrypt.Verify(userDto.Password, userModel.PasswordHash))
            {
                return userModel;
            }
            else
            {
                return null;
            }
        }

        public UserReadDto Register(UserCreateDto userDto)
        {
            var userModel = _mapper.Map<User>(userDto);

            userModel.PasswordHash = BCrypt.Net.BCrypt.HashPassword(userDto.Password);

            _repository.Create(userModel);
            _repository.SaveChanges();

            return _mapper.Map<UserReadDto>(userModel);
        }
    }
}
