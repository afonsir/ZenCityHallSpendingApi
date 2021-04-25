﻿using Microsoft.EntityFrameworkCore.Migrations;

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
                    
                    '03744-01',
                    'O08699/2021',
                    'Associacao Esportiva de Inclusao Social  (17.289.742/0001-81)',
                    'TERMO DE FOMENTO N.10/20-PROJETO ESPORTE E CULTURA EM ACAO',
                    'Assistencia Social',
                    'Assistencia a Crianca e ao Adolescente',
                    'Rec.prop.de Fdos Especiais de Despesa-vinc.-ex.ant',
                    'Fundo Municipal da Crianca e Adolescente',
                    'Outros Servicos de Terceiros - Pessoa Juridica',
                    'Secretaria Municipal de Comunicacao e Relacoes Sociais',
                    'Gestao das Relacoes Intersetoriais e Governamentai',
                    'Manutencao e Ampliacao de Projetos Co-financiados pelo Fmdca',
                    'Outros',
                    to_timestamp('12/03/2021', 'DD/MM/YYYY')::timestamp without time zone,
                    100000.00,  
                    'Outros',
                    '00041 2021',
                    to_timestamp('18/03/2021', 'DD/MM/YYYY')::timestamp without time zone,
                    50000.00,
                    to_timestamp('26/03/2021', 'DD/MM/YYYY')::timestamp without time zone,
                    50000.00 
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
                    '01358-01',
                    'G00068/2020',
                    'Step Give Loc de Equip Eventos Eireli  (06.878.252/0001-02)',
                    'CONTRATACAO DE EMPRESA PARA LOCACAO DE C ONTAINERS, ESCRITORIO E GUARITA C/ WC',
                    'Comercio e Servicos',
                    'Turismo',
                    'Tesouro',
                    'Geral',
                    'Locacao de Maquinas e Equipamentos',
                    'Secretaria Municipal de Turismo',
                    'Guaruja - Turismo o Ano Todo',
                    'Manutencao dos Servicos da Secretaria de Turismo',
                    'Pregão',
                    to_timestamp('13/01/2021', 'DD/MM/YYYY')::timestamp without time zone,
                    27999.96,
                    'Nota Fiscal',
                    '0000001162',
                    to_timestamp('12/02/2021', 'DD/MM/YYYY')::timestamp without time zone,
                    2333.33,
                    to_timestamp('23/02/2021', 'DD/MM/YYYY')::timestamp without time zone,
                    2333.33 
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
                    '00571-01',
                    'S33401/2019',
                    'Marcelo Barbosa Simoes  (197.481.188-35)',
                    'LOCACAO DE IMOVEIS-T.A.01-CONTR.261/19',
                    'Comercio e Servicos',
                    'Turismo',
                    'Tesouro',
                    'Geral',
                    'Locacao de Imoveis',
                    'Secretaria Municipal de Turismo',
                    'Guaruja - Turismo o Ano Todo',
                    'Manutencao dos Servicos da Secretaria de Turismo',
                    'Dispensa de Licitação',
                    to_timestamp('04/01/2021', 'DD/MM/YYYY')::timestamp without time zone,
                    18200.00,
                    'Outros',
                    '0000012021',
                    to_timestamp('03/02/2021', 'DD/MM/YYYY')::timestamp without time zone,
                    9100.00,
                    to_timestamp('11/02/2021', 'DD/MM/YYYY')::timestamp without time zone,
                    9100.00 
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
                    '00530-01',
                    'G00102/2018',
                    'Gtermica Comercio Solucoes e Servicos Eireli  (11.352.787/0001-77)',
                    'CONTRATACAO DE EMPRESA ESPECIALIZADA NA DE SERVICO DE MANUTENCAO PREVE',
                    'Cultura',
                    'Difusao Cultural',
                    'Tesouro',
                    'Geral',
                    'Servicos Tecnicos Profissionais',
                    'Secretaria Municipal de Cultura',
                    'Cultura em Cena',
                    'Estrutura Organizacional da Secult',
                    'Pregão',
                    to_timestamp('04/01/2021', 'DD/MM/YYYY')::timestamp without time zone,
                    2938.18,
                    'Nota Fiscal',
                    '0000004940',
                    to_timestamp('17/02/2021', 'DD/MM/YYYY')::timestamp without time zone,
                    1469.09,
                    to_timestamp('16/03/2021', 'DD/MM/YYYY')::timestamp without time zone,
                    1469.09 

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
                    '00917-01',
                    'O00000/2021',
                    'Fl. de Pagto Contratados e Assalariados',
                    'EMPENHO DE FOLHA DE PAGTO - 00/2021',
                    'Educacao',
                    'Educacao Especial',
                    'Tesouro',
                    'Ensino Fundamental',
                    'Abono de Permanencia',
                    'Secretaria Municipal de Educacao',
                    'Educacao Humanizada de Qualidade, Com Oportunidade',
                    'Desenvolvimento e Gestao da Educacao Especial',
                    'Outros',
                    to_timestamp('04/01/2021', 'DD/MM/YYYY')::timestamp without time zone,
                    16843.72,
                    'Outros',
                    'RP01-00530',
                    to_timestamp('22/01/2021', 'DD/MM/YYYY')::timestamp without time zone,
                    16843.72,
                    to_timestamp('29/01/2021', 'DD/MM/YYYY')::timestamp without time zone,
                    16843.72 
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
                    '00556-01',
                    'I00015/2019',
                    'Autopass S.a  (07.140.538/0001-40)',
                    'SEDUC - CT 69/20, VALE TRANSPORTE DOS FUNCIONARIOS.',
                    'Educacao',
                    'Ensino Fundamental',
                    'Tesouro',
                    'Ensino Fundamental',
                    'Vale-transporte',
                    'Secretaria Municipal de Educacao',
                    'Educacao Humanizada de Qualidade, Com Oportunidade',
                    'Desenvolvimento e Gestao do Ensino Fundamental',
                    'Inexigibilidade',
                    to_timestamp('04/01/2021', 'DD/MM/YYYY')::timestamp without time zone,
                    60000.00,
                    'Outros',
                    '0000022021',
                    to_timestamp('26/01/2021', 'DD/MM/YYYY')::timestamp without time zone,
                    26058.60,
                    to_timestamp('27/01/2021', 'DD/MM/YYYY')::timestamp without time zone,
                    26058.60
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
                    '03629-01',
                    'E00033/2020',
                    'Wama Produtos para Laboratorio Ltda  (66.000.787/0001-08)',
                    'ATA 37/2021 PREGAO 33/20 AQUISICAO DE TESTE RAPIDO DE COVID-19',
                    'Saude',
                    'Assistencia Hospitalar e Ambulatorial',
                    'Transf.e Convenios Federais-vinculados-exec.anter.',
                    'Port 2358 02/09/20 Min Saude - Rastream e Monitora',
                    'Material Laboratorial',
                    'Secretaria Municipal de Saude',
                    'Rede de Urgencias e Emergencias',
                    'Qualificar e Reorganizar a Rede de Urgencia e Emer Gencia Garantindo Sua Manutenc',
                    'Pregão Eletronico',
                    to_timestamp('04/03/2021', 'DD/MM/YYYY')::timestamp without time zone,
                    32000.00,
                    'Nota Fiscal',
                    '0000059166',
                    to_timestamp('30/03/2021', 'DD/MM/YYYY')::timestamp without time zone,
                    32000.00,
                    to_timestamp('14/04/2021', 'DD/MM/YYYY')::timestamp without time zone,
                    32000.00
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
                    '01188-01',
                    'O00000/2021',
                    'Caixa Economica Federal -CEF  (00.360.305/0001-04)',
                    'EMPENHO DE FOLHA DE PAGTO - 00/2021',
                    'Seguranca Publica',
                    'Policiamento',
                    'Tesouro',
                    'Geral',
                    'Fgts',
                    'Sec. Mun. de Defesa e Conviv. Social',
                    'Seguranca para as Pessoas',
                    'Incrementacao da Guarda CIVIL Municipal',
                    'Outros',
                    to_timestamp('04/01/2021', 'DD/MM/YYYY')::timestamp without time zone,
                    1986.66,
                    'Outros',
                    'NE00-00540',
                    to_timestamp('29/01/2021', 'DD/MM/YYYY')::timestamp without time zone,
                    1986.66,
                    to_timestamp('05/02/2021', 'DD/MM/YYYY')::timestamp without time zone,
                    1986.66 
                );
            ");

        }

        protected override void Down(MigrationBuilder migrationBuilder) { }
    }
}
