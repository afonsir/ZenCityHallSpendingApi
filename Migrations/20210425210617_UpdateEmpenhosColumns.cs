using Microsoft.EntityFrameworkCore.Migrations;

namespace ZenCityHallSpendingApi.Migrations
{
    public partial class UpdateEmpenhosColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataLiquicao",
                table: "Empenhos",
                newName: "DataLiquidacao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataLiquidacao",
                table: "Empenhos",
                newName: "DataLiquicao");
        }
    }
}
