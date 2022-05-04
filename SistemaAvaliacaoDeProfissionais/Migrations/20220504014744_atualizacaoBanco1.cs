using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaAvaliacaoDeProfissionais.Migrations
{
    public partial class atualizacaoBanco1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Profissionais",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Profissionais");
        }
    }
}
