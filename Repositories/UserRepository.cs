using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ZenCityHallSpendingApi.Data;
using ZenCityHallSpendingApi.Models;

namespace ZenCityHallSpendingApi.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;
        private readonly DbSet<User> _dataset;

        public UserRepository(DataContext context)
        {
            _context = context;
            _dataset = _context.Set<User>();
        }

        public User FindByEmail(string Email)
        {
            return _dataset.SingleOrDefault(e => e.Email == Email);
        }

        public void Create(User entity)
        {
            if (entity == null) throw new ArgumentNullException("User");

            _dataset.Add(entity);
        }

        public void Update(User entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(User entity)
        {
            throw new System.NotImplementedException();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
