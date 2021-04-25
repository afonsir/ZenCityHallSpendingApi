using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ZenCityHallSpendingApi.Data;
using ZenCityHallSpendingApi.Models;

namespace ZenCityHallSpendingApi.Repositories
{
    public class EmpenhoRepository : IEmpenhoRepository
    {
        private readonly DataContext _context;
        private readonly DbSet<Empenho> _dataset;

        public EmpenhoRepository(DataContext context)
        {
            _context = context;
            _dataset = _context.Set<Empenho>();
        }

        public IEnumerable<Empenho> FindAll()
        {
            return _dataset.AsEnumerable();
        }
    }
}
