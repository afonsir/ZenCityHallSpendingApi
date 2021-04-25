using Microsoft.EntityFrameworkCore.Migrations;

namespace ZenCityHallSpendingApi.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                insert into ""Empenhos""(
                    ""Codigo"",
                    ""NumeroProcesso"",
                    ""Credor"",
                    ""Descricao"",
                    ""Funcao"",
                    ""SubFuncao"",
                    ""FonteRecurso"",
                    ""Aplicacao"",
                    ""Natureza"",
                    ""UnidadeOrcamentaria"",
                    ""Programa"",
                    ""Acao"",
                    ""TipoLicitacao"",
                    ""DataEmpenho"",
                    ""ValorEmpenhado"",
                    ""TipoDoctoFiscal"",
                    ""NroDoctoFiscal"",
                    ""DataLiquidacao"",
                    ""ValorLiquidacao"",
                    ""DataPagamento"",
                    ""ValorPago""
                ) values (
                    '00001-01',
                    'O38458/2020',
                    'Jose Alberto dos Santos Silva  (133.554.948-01)',
                    'ADIANTAMENTO P/POSTERIOR PRESTACAO DE CONTAS',
                    'Administracao',
                    'Administracao Geral',
                    'Tesouro',
                    'Geral',
                    'Outros Materiais de Consumo',
                    'Advocacia Geral do Municipio',
                    'Gestao Juridico-administrativa',
                    'Despesas em Regime de Adiantamento da Agm',
                    'Outros',
                    to_timestamp('04/01/2021', 'DD/MM/YYYY')::timestamp without time zone,
                    1500.00,
                    'Adiantamento',
                    '00NE-00001',
                    to_timestamp('04/01/2021', 'DD/MM/YYYY')::timestamp without time zone,
                    1500.00,
                    to_timestamp('20/01/2021', 'DD/MM/YYYY')::timestamp without time zone,
                    1500.00
                );

                insert into ""Empenhos""(
                    ""Codigo"",
                    ""NumeroProcesso"",
                    ""Credor"",
                    ""Descricao"",
                    ""Funcao"",
                    ""SubFuncao"",
                    ""FonteRecurso"",
                    ""Aplicacao"",
                    ""Natureza"",
                    ""UnidadeOrcamentaria"",
                    ""Programa"",
                    ""Acao"",
                    ""TipoLicitacao"",
                    ""DataEmpenho"",
                    ""ValorEmpenhado"",
                    ""TipoDoctoFiscal"",
                    ""NroDoctoFiscal"",
                    ""DataLiquidacao"",
                    ""ValorLiquidacao"",
                    ""DataPagamento"",
                    ""ValorPago""
                ) values (
                    '00002-01',
                    'O38458/2020',
                    'Jose Alberto dos Santos Silva  (133.554.948-01)',
                    'ADIANTAMENTO P/POSTERIOR PRESTACAO DE CONTAS',
                    'Administracao',
                    'Administracao Geral',
                    'Tesouro',
                    'Geral',
                    'Outros Servicos de Terceiros - Pessoa Juridica',
                    'Advocacia Geral do Municipio',
                    'Gestao Juridico-administrativa',
                    'Despesas em Regime de Adiantamento da Agm',
                    'Outros',
                    to_timestamp('04/01/2021', 'DD/MM/YYYY')::timestamp without time zone,
                    1500.00,
                    'Adiantamento',
                    '00NE-00002',
                    to_timestamp('04/01/2021', 'DD/MM/YYYY')::timestamp without time zone,
                    1500.00,
                    to_timestamp('20/01/2021', 'DD/MM/YYYY')::timestamp without time zone,
                    1500.00
                );
            ");

        }

        protected override void Down(MigrationBuilder migrationBuilder) { }
    }
}
