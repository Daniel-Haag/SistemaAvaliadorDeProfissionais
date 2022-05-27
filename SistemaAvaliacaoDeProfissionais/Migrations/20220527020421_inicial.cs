using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaAvaliacaoDeProfissionais.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Periodos",
                columns: table => new
                {
                    PeriodoID = table.Column<int>(type: "int", nullable: false),
                    CodigoPeriodo = table.Column<int>(type: "int", nullable: false),
                    Periodo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Periodos", x => x.PeriodoID);
                });

            migrationBuilder.CreateTable(
                name: "Setores",
                columns: table => new
                {
                    setorID = table.Column<int>(type: "int", nullable: false),
                    nomeSetor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setores", x => x.setorID);
                });

            migrationBuilder.CreateTable(
                name: "StatusAvaliacoes",
                columns: table => new
                {
                    statusAvaliacaoID = table.Column<int>(type: "int", nullable: false),
                    nomeStatusAvaliacao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusAvaliacoes", x => x.statusAvaliacaoID);
                });

            migrationBuilder.CreateTable(
                name: "TipoCargos",
                columns: table => new
                {
                    tipoCargoID = table.Column<int>(type: "int", nullable: false),
                    nomeTipoCargo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCargos", x => x.tipoCargoID);
                });

            migrationBuilder.CreateTable(
                name: "UsuariosExclusivos",
                columns: table => new
                {
                    UsuarioExclusivoID = table.Column<int>(type: "int", nullable: false),
                    UsuarioLogin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuariosExclusivos", x => x.UsuarioExclusivoID);
                });

            migrationBuilder.CreateTable(
                name: "Cargos",
                columns: table => new
                {
                    cargoID = table.Column<int>(type: "int", nullable: false),
                    nomeCargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoCargoID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargos", x => x.cargoID);
                    table.ForeignKey(
                        name: "FK_Cargos_TipoCargos_TipoCargoID",
                        column: x => x.TipoCargoID,
                        principalTable: "TipoCargos",
                        principalColumn: "tipoCargoID");
                });

            migrationBuilder.CreateTable(
                name: "Questionarios",
                columns: table => new
                {
                    QuestaoID = table.Column<int>(type: "int", nullable: false),
                    Questao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TituloQuestao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoCargoID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionarios", x => x.QuestaoID);
                    table.ForeignKey(
                        name: "FK_Questionarios_TipoCargos_TipoCargoID",
                        column: x => x.TipoCargoID,
                        principalTable: "TipoCargos",
                        principalColumn: "tipoCargoID");
                });

            migrationBuilder.CreateTable(
                name: "Profissionais",
                columns: table => new
                {
                    profissionalID = table.Column<int>(type: "int", nullable: false),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    senha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    matricula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SetorID = table.Column<int>(type: "int", nullable: true),
                    CargoID = table.Column<int>(type: "int", nullable: true),
                    admissao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusAvaliacaoID = table.Column<int>(type: "int", nullable: true),
                    gestor = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profissionais", x => x.profissionalID);
                    table.ForeignKey(
                        name: "FK_Profissionais_Cargos_CargoID",
                        column: x => x.CargoID,
                        principalTable: "Cargos",
                        principalColumn: "cargoID");
                    table.ForeignKey(
                        name: "FK_Profissionais_Setores_SetorID",
                        column: x => x.SetorID,
                        principalTable: "Setores",
                        principalColumn: "setorID");
                    table.ForeignKey(
                        name: "FK_Profissionais_StatusAvaliacoes_StatusAvaliacaoID",
                        column: x => x.StatusAvaliacaoID,
                        principalTable: "StatusAvaliacoes",
                        principalColumn: "statusAvaliacaoID");
                });

            migrationBuilder.CreateTable(
                name: "PeriodosAvaliacao",
                columns: table => new
                {
                    PeriodoAvaliacaoID = table.Column<int>(type: "int", nullable: false),
                    PeriodoID = table.Column<int>(type: "int", nullable: false),
                    ProfissionalID = table.Column<int>(type: "int", nullable: false),
                    DataInicioAvaliacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataInicioAutoAvaliacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataExpiracaoAvaliacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataExpiracaoAutoAvaliacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AvaliacaoExpirada = table.Column<bool>(type: "bit", nullable: false),
                    Liberada = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeriodosAvaliacao", x => x.PeriodoAvaliacaoID);
                    table.ForeignKey(
                        name: "FK_PeriodosAvaliacao_Periodos_PeriodoID",
                        column: x => x.PeriodoID,
                        principalTable: "Periodos",
                        principalColumn: "PeriodoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeriodosAvaliacao_Profissionais_ProfissionalID",
                        column: x => x.ProfissionalID,
                        principalTable: "Profissionais",
                        principalColumn: "profissionalID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlanosDeAcao",
                columns: table => new
                {
                    PlanoDeAcaoID = table.Column<int>(type: "int", nullable: false),
                    profissionalID = table.Column<int>(type: "int", nullable: false),
                    TextoQuestao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextoPlanoDeAcao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PeriodoID = table.Column<int>(type: "int", nullable: false),
                    ResultadoDaAcaoProposta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsideracoesFinaisDosPlanosDeAcao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsideracoesDoColaboradorAvaliado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanosDeAcao", x => x.PlanoDeAcaoID);
                    table.ForeignKey(
                        name: "FK_PlanosDeAcao_Periodos_PeriodoID",
                        column: x => x.PeriodoID,
                        principalTable: "Periodos",
                        principalColumn: "PeriodoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlanosDeAcao_Profissionais_profissionalID",
                        column: x => x.profissionalID,
                        principalTable: "Profissionais",
                        principalColumn: "profissionalID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResultadoAvaliacoes",
                columns: table => new
                {
                    ResultadoAvaliacaoID = table.Column<int>(type: "int", nullable: false),
                    ProfissionalID = table.Column<int>(type: "int", nullable: false),
                    NotaAutoAvaliacao = table.Column<double>(type: "float", nullable: true),
                    NotaAvaliacao = table.Column<double>(type: "float", nullable: true),
                    DataAutoAvaliacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAvaliacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PeriodoID = table.Column<int>(type: "int", nullable: true),
                    RespostasAutoAvaliacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RespostasAvaliacao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultadoAvaliacoes", x => x.ResultadoAvaliacaoID);
                    table.ForeignKey(
                        name: "FK_ResultadoAvaliacoes_Periodos_PeriodoID",
                        column: x => x.PeriodoID,
                        principalTable: "Periodos",
                        principalColumn: "PeriodoID");
                    table.ForeignKey(
                        name: "FK_ResultadoAvaliacoes_Profissionais_ProfissionalID",
                        column: x => x.ProfissionalID,
                        principalTable: "Profissionais",
                        principalColumn: "profissionalID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegistroDeAdvertencias",
                columns: table => new
                {
                    RegistroDeAdvertenciasID = table.Column<int>(type: "int", nullable: false),
                    DataAdvertencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CaminhoArquivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PeriodoAvaliacaoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroDeAdvertencias", x => x.RegistroDeAdvertenciasID);
                    table.ForeignKey(
                        name: "FK_RegistroDeAdvertencias_PeriodosAvaliacao_PeriodoAvaliacaoID",
                        column: x => x.PeriodoAvaliacaoID,
                        principalTable: "PeriodosAvaliacao",
                        principalColumn: "PeriodoAvaliacaoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cargos_TipoCargoID",
                table: "Cargos",
                column: "TipoCargoID");

            migrationBuilder.CreateIndex(
                name: "IX_PeriodosAvaliacao_PeriodoID",
                table: "PeriodosAvaliacao",
                column: "PeriodoID");

            migrationBuilder.CreateIndex(
                name: "IX_PeriodosAvaliacao_ProfissionalID",
                table: "PeriodosAvaliacao",
                column: "ProfissionalID");

            migrationBuilder.CreateIndex(
                name: "IX_PlanosDeAcao_PeriodoID",
                table: "PlanosDeAcao",
                column: "PeriodoID");

            migrationBuilder.CreateIndex(
                name: "IX_PlanosDeAcao_profissionalID",
                table: "PlanosDeAcao",
                column: "profissionalID");

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

            migrationBuilder.CreateIndex(
                name: "IX_Questionarios_TipoCargoID",
                table: "Questionarios",
                column: "TipoCargoID");

            migrationBuilder.CreateIndex(
                name: "IX_RegistroDeAdvertencias_PeriodoAvaliacaoID",
                table: "RegistroDeAdvertencias",
                column: "PeriodoAvaliacaoID");

            migrationBuilder.CreateIndex(
                name: "IX_ResultadoAvaliacoes_PeriodoID",
                table: "ResultadoAvaliacoes",
                column: "PeriodoID");

            migrationBuilder.CreateIndex(
                name: "IX_ResultadoAvaliacoes_ProfissionalID",
                table: "ResultadoAvaliacoes",
                column: "ProfissionalID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlanosDeAcao");

            migrationBuilder.DropTable(
                name: "Questionarios");

            migrationBuilder.DropTable(
                name: "RegistroDeAdvertencias");

            migrationBuilder.DropTable(
                name: "ResultadoAvaliacoes");

            migrationBuilder.DropTable(
                name: "UsuariosExclusivos");

            migrationBuilder.DropTable(
                name: "PeriodosAvaliacao");

            migrationBuilder.DropTable(
                name: "Periodos");

            migrationBuilder.DropTable(
                name: "Profissionais");

            migrationBuilder.DropTable(
                name: "Cargos");

            migrationBuilder.DropTable(
                name: "Setores");

            migrationBuilder.DropTable(
                name: "StatusAvaliacoes");

            migrationBuilder.DropTable(
                name: "TipoCargos");
        }
    }
}
