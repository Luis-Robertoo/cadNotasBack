using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadNotas.Migrations
{
    public partial class ArrumandoAsTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Notas_NotaCNPJ",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_NotaCNPJ",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notas",
                table: "Notas");

            migrationBuilder.DropColumn(
                name: "NotaCNPJ",
                table: "Produtos");

            migrationBuilder.AlterColumn<long>(
                name: "numCupom",
                table: "Notas",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notas",
                table: "Notas",
                column: "numCupom");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Notas",
                table: "Notas");

            migrationBuilder.AddColumn<string>(
                name: "NotaCNPJ",
                table: "Produtos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "numCupom",
                table: "Notas",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notas",
                table: "Notas",
                column: "CNPJ");

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
    }
}
