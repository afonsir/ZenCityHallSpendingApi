using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ZenCityHallSpendingApi.Migrations
{
    public partial class CreateEmpenhosTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empenhos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Codigo = table.Column<string>(type: "text", nullable: true),
                    NumeroProcesso = table.Column<string>(type: "text", nullable: true),
                    Credor = table.Column<string>(type: "text", nullable: true),
                    Descricao = table.Column<string>(type: "text", nullable: true),
                    Funcao = table.Column<string>(type: "text", nullable: true),
                    SubFuncao = table.Column<string>(type: "text", nullable: true),
                    FonteRecurso = table.Column<string>(type: "text", nullable: true),
                    Aplicacao = table.Column<string>(type: "text", nullable: true),
                    Natureza = table.Column<string>(type: "text", nullable: true),
                    UnidadeOrcamentaria = table.Column<string>(type: "text", nullable: true),
                    Programa = table.Column<string>(type: "text", nullable: true),
                    Acao = table.Column<string>(type: "text", nullable: true),
                    TipoLicitacao = table.Column<string>(type: "text", nullable: true),
                    DataEmpenho = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ValorEmpenhado = table.Column<decimal>(type: "numeric", nullable: false),
                    TipoDoctoFiscal = table.Column<string>(type: "text", nullable: true),
                    NroDoctoFiscal = table.Column<string>(type: "text", nullable: true),
                    DataLiquicao = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ValorLiquidacao = table.Column<decimal>(type: "numeric", nullable: false),
                    DataPagamento = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ValorPago = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empenhos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empenhos");
        }
    }
}
