using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendaSalas.Migrations
{
    public partial class Inicial05 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SalaId",
                table: "Endereco",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Sala",
                columns: table => new
                {
                    SalaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identificacao = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Voltagem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    medidaLado1EmMetros = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    medidaLado2EmMetros = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    numeroMaximoDePessoas = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Janelas = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sala", x => x.SalaId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_SalaId",
                table: "Endereco",
                column: "SalaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Sala_SalaId",
                table: "Endereco",
                column: "SalaId",
                principalTable: "Sala",
                principalColumn: "SalaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Sala_SalaId",
                table: "Endereco");

            migrationBuilder.DropTable(
                name: "Sala");

            migrationBuilder.DropIndex(
                name: "IX_Endereco_SalaId",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "SalaId",
                table: "Endereco");
        }
    }
}
