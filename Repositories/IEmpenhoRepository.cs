using System.Collections.Generic;
using ZenCityHallSpendingApi.Models;

namespace ZenCityHallSpendingApi.Repositories
{
    public interface IEmpenhoRepository
    {
        IEnumerable<Empenho> FindAll();
    }
}
