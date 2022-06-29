using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadNotas.Migrations
{
    public partial class AdicionadoCampoValor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "valorNotaProdutos",
                table: "Notas",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "valorNotaProdutos",
                table: "Notas");
        }
    }
}
