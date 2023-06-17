using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BFS_SisControl.Server.Migrations
{
    /// <inheritdoc />
    public partial class TabelaInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TbPessoa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Cpf = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Fone = table.Column<string>(type: "TEXT", nullable: false),
                    CEP = table.Column<string>(type: "TEXT", nullable: false),
                    Endereco = table.Column<string>(type: "TEXT", nullable: false),
                    Complemento = table.Column<string>(type: "TEXT", nullable: false),
                    Bairro = table.Column<string>(type: "TEXT", nullable: false),
                    Cidade = table.Column<string>(type: "TEXT", nullable: false),
                    UF = table.Column<string>(type: "TEXT", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbPessoa", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TbPessoa",
                columns: new[] { "Id", "Bairro", "CEP", "Cidade", "Complemento", "Cpf", "DataAtualizacao", "DataCadastro", "DataNascimento", "Email", "Endereco", "Fone", "Nome", "UF" },
                values: new object[,]
                {
                    { 1, "Este Aqui", "29.200-001", "Guarapari", "Apto 001", "111.111.111-11", new DateTime(2023, 6, 17, 8, 51, 40, 532, DateTimeKind.Local).AddTicks(7000), new DateTime(2023, 6, 17, 8, 51, 40, 532, DateTimeKind.Local).AddTicks(6988), new DateTime(1972, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teste@teste.com", "Rua da minha casa, 001", "(27) 99999-1234", "Primeira Pessoa Cadastrada", "ES" },
                    { 2, "Este Aqui", "29.200-002", "Guarapari", "Apto 002", "222.222.222-22", new DateTime(2023, 6, 17, 8, 51, 40, 532, DateTimeKind.Local).AddTicks(7091), new DateTime(2023, 6, 17, 8, 51, 40, 532, DateTimeKind.Local).AddTicks(7090), new DateTime(1974, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teste@teste.com", "Rua da minha casa, 002", "(27) 99999-2345", "Segunda Pessoa Cadastrada", "ES" },
                    { 3, "Este Aqui", "29.200-003", "Guarapari", "Apto 003", "333.333.333-33", new DateTime(2023, 6, 17, 8, 51, 40, 532, DateTimeKind.Local).AddTicks(7101), new DateTime(2023, 6, 17, 8, 51, 40, 532, DateTimeKind.Local).AddTicks(7101), new DateTime(1997, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teste@teste.com", "Rua da minha casa, 003", "(27) 99999-3456", "Terceira Pessoa Cadastrada", "ES" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbPessoa");
        }
    }
}
