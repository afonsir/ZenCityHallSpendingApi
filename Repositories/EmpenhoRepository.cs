using System.Collections.Generic;
using System.Linq;
using Dtos;
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

        public EmpenhoTotalValueDto FilterByFunction(string function)
        {   
           
            var totalValorEmpenhado = _dataset.Where(vl => vl.Funcao == function).Sum(x => x.ValorEmpenhado);
            var totalValorPago =  _dataset.Where(vl => vl.Funcao == function).Sum(x => x.ValorPago);
            var total = totalValorEmpenhado - totalValorPago;
            var resultado = new EmpenhoTotalValueDto(){
                Funcao = function,
                ValorEmpenhado = totalValorEmpenhado,
                ValorPago = totalValorPago,
                Saldo = total
            };           
            return resultado;           
        }

        public IEnumerable<Empenho> FindAll()
        {
            return _dataset.AsEnumerable();
        }
    }
}
