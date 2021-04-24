using System.Collections.Generic;
using ZenCityHallSpendingApi.Models;

namespace ZenCityHallSpendingApi.Repositories
{
    public interface IEmpenhoRepository
    {
        IEnumerable<Empenho> FindAll();
        Empenho FindById(int id);
        void Create(Empenho entity);
        void Update(Empenho entity);
        void Delete(Empenho entity);
        bool SaveChanges();
    }
}
