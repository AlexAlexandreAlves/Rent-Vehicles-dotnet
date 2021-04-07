using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Programa.Migrations
{
    public partial class Projetos_Cs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    DtNascimento = table.Column<DateTime>(nullable: false),
                    Cpf = table.Column<string>(nullable: true),
                    DiasParaRetorno = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VeiculosLeves",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Marca = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    Ano = table.Column<int>(nullable: false),
                    Preco = table.Column<double>(nullable: false),
                    Cor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VeiculosLeves", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VeiculosPesados",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Marca = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    Ano = table.Column<int>(nullable: false),
                    Preco = table.Column<double>(nullable: false),
                    Restricoes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VeiculosPesados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locacoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClienteId = table.Column<int>(nullable: false),
                    DataLocacao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locacoes_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocacaoVeiculoLeves",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    IdLocacao = table.Column<int>(nullable: false),
                    LocacaoId = table.Column<int>(nullable: true),
                    IdVeiculoLeve = table.Column<int>(nullable: false),
                    VeiculoLeveId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocacaoVeiculoLeves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocacaoVeiculoLeves_Locacoes_LocacaoId",
                        column: x => x.LocacaoId,
                        principalTable: "Locacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocacaoVeiculoLeves_VeiculosLeves_VeiculoLeveId",
                        column: x => x.VeiculoLeveId,
                        principalTable: "VeiculosLeves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LocacaoVeiculoPesados",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    IdLocacao = table.Column<int>(nullable: false),
                    LocacaoId = table.Column<int>(nullable: true),
                    IdVeiculoPesado = table.Column<int>(nullable: false),
                    VeiculoPesadoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocacaoVeiculoPesados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocacaoVeiculoPesados_Locacoes_LocacaoId",
                        column: x => x.LocacaoId,
                        principalTable: "Locacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocacaoVeiculoPesados_VeiculosPesados_VeiculoPesadoId",
                        column: x => x.VeiculoPesadoId,
                        principalTable: "VeiculosPesados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LocacaoVeiculoLeves_LocacaoId",
                table: "LocacaoVeiculoLeves",
                column: "LocacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_LocacaoVeiculoLeves_VeiculoLeveId",
                table: "LocacaoVeiculoLeves",
                column: "VeiculoLeveId");

            migrationBuilder.CreateIndex(
                name: "IX_LocacaoVeiculoPesados_LocacaoId",
                table: "LocacaoVeiculoPesados",
                column: "LocacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_LocacaoVeiculoPesados_VeiculoPesadoId",
                table: "LocacaoVeiculoPesados",
                column: "VeiculoPesadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Locacoes_ClienteId",
                table: "Locacoes",
                column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocacaoVeiculoLeves");

            migrationBuilder.DropTable(
                name: "LocacaoVeiculoPesados");

            migrationBuilder.DropTable(
                name: "VeiculosLeves");

            migrationBuilder.DropTable(
                name: "Locacoes");

            migrationBuilder.DropTable(
                name: "VeiculosPesados");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
