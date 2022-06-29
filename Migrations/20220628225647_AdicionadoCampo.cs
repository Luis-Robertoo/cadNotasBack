using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadNotas.Migrations
{
    public partial class AdicionadoCampo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "produtosComprados",
                table: "Notas",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "produtosComprados",
                table: "Notas");
        }
    }
}
