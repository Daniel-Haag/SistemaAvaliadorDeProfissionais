using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaAvaliacaoDeProfissionais.Migrations
{
    public partial class teste2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Profissionais_CargoID",
                table: "Profissionais",
                column: "CargoID");

            migrationBuilder.CreateIndex(
                name: "IX_Profissionais_SetorID",
                table: "Profissionais",
                column: "SetorID");

            migrationBuilder.CreateIndex(
                name: "IX_Profissionais_StatusAvaliacaoID",
                table: "Profissionais",
                column: "StatusAvaliacaoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Profissionais_Cargos_CargoID",
                table: "Profissionais",
                column: "CargoID",
                principalTable: "Cargos",
                principalColumn: "CargoID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Profissionais_Setores_SetorID",
                table: "Profissionais",
                column: "SetorID",
                principalTable: "Setores",
                principalColumn: "SetorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Profissionais_StatusAvaliacoes_StatusAvaliacaoID",
                table: "Profissionais",
                column: "StatusAvaliacaoID",
                principalTable: "StatusAvaliacoes",
                principalColumn: "StatusAvaliacaoID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profissionais_Cargos_CargoID",
                table: "Profissionais");

            migrationBuilder.DropForeignKey(
                name: "FK_Profissionais_Setores_SetorID",
                table: "Profissionais");

            migrationBuilder.DropForeignKey(
                name: "FK_Profissionais_StatusAvaliacoes_StatusAvaliacaoID",
                table: "Profissionais");

            migrationBuilder.DropIndex(
                name: "IX_Profissionais_CargoID",
                table: "Profissionais");

            migrationBuilder.DropIndex(
                name: "IX_Profissionais_SetorID",
                table: "Profissionais");

            migrationBuilder.DropIndex(
                name: "IX_Profissionais_StatusAvaliacaoID",
                table: "Profissionais");
        }
    }
}
