using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadNotas.Migrations
{
    public partial class CriandoNota2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NotaCNPJ",
                table: "Produtos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Notas",
                columns: table => new
                {
                    CNPJ = table.Column<string>(type: "TEXT", nullable: false),
                    canalCompra = table.Column<string>(type: "TEXT", nullable: false),
                    dataCompra = table.Column<DateTime>(type: "TEXT", nullable: false),
                    numCupom = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notas", x => x.CNPJ);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_NotaCNPJ",
                table: "Produtos",
                column: "NotaCNPJ");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Notas_NotaCNPJ",
                table: "Produtos",
                column: "NotaCNPJ",
                principalTable: "Notas",
                principalColumn: "CNPJ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Notas_NotaCNPJ",
                table: "Produtos");

            migrationBuilder.DropTable(
                name: "Notas");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_NotaCNPJ",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "NotaCNPJ",
                table: "Produtos");
        }
    }
}
