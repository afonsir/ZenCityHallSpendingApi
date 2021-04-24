using System;

namespace ZenCityHallSpendingApi.Models
{
    public class Empenho
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string NumeroProcesso { get; set; }
        public string Credor { get; set; }
        public string Descricao { get; set; }
        public string Funcao { get; set; }
        public string SubFuncao { get; set; }
        public string FonteRecurso { get; set; }
        public string Aplicacao { get; set; }
        public string Natureza { get; set; }
        public string UnidadeOrcamentaria { get; set; }
        public string Programa { get; set; }
        public string Acao { get; set; }
        public string TipoLicitacao { get; set; }
        public DateTime DataEmpenho { get; set; }
        public Decimal ValorEmpenhado { get; set; }
        public string TipoDoctoFiscal  { get; set; }
        public string NroDoctoFiscal { get; set; }
        public DateTime DataLiquicao { get; set; }
        public Decimal ValorLiquidacao { get; set; }
        public DateTime DataPagamento { get; set; }
        public Decimal ValorPago { get; set; }
    }
}
