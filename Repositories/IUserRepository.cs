using ZenCityHallSpendingApi.Models;

namespace ZenCityHallSpendingApi.Repositories
{
    public interface IUserRepository
    {
        User FindByEmail(string Email);
        void Create(User entity);
        void Update(User entity);
        void Delete(User entity);
        bool SaveChanges();
    }
}
