using Microsoft.EntityFrameworkCore;
using ZenCityHallSpendingApi.Models;

namespace ZenCityHallSpendingApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        
        public DbSet<Empenho> Empenhos { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
