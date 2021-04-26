using System;

namespace Dtos
{
    public class EmpenhoTotalValueDto
    {
        public string Funcao { get; set; }
        public Decimal ValorEmpenhado { get; set; }       
        public Decimal ValorPago { get; set; }
        public Decimal Saldo { get; set; }
    }
}