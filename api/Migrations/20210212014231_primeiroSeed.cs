using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace api.Migrations
{
    public partial class primeiroSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Enderecos",
                columns: new[] { "Id", "Cep", "Cidade", "Complemento", "Estado", "Logradouro", "Numero" },
                values: new object[] { -1, "00000-000", "Belo Horizonte", 0, "MG", "Rua Fulano de tal, Bairro Beltrano", 31 });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Cpf", "DiaDeNascimento", "EndereçoId", "Nome", "Senha", "TipoDeUsuario" },
                values: new object[] { -1, "111.111.111-11", new DateTime(2021, 2, 11, 22, 42, 30, 364, DateTimeKind.Local).AddTicks(7154), -1, "Cássio Morais", "senhateste@", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
