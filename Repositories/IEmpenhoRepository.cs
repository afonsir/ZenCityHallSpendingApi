using System.Collections.Generic;
using Dtos;
using ZenCityHallSpendingApi.Models;

namespace ZenCityHallSpendingApi.Repositories
{
    public interface IEmpenhoRepository
    {
        IEnumerable<Empenho> FindAll();
        EmpenhoTotalValueDto FilterByFunction(string function);
    }
}
