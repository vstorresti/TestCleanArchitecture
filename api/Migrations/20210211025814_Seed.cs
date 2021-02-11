using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace api.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "Id", "Cpf", "DiaDeNascimento", "EnderecoId", "Nome", "Senha", "TipoDeUsuario" },
                values: new object[] { -1, "111.111.111-11", new DateTime(2021, 2, 10, 23, 58, 13, 698, DateTimeKind.Local).AddTicks(3887), null, "Cássio Morais", "senhateste@", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "Id", "Cpf", "DiaDeNascimento", "EnderecoId", "Nome", "Senha", "TipoDeUsuario" },
                values: new object[] { 1, "111.111.111-11", new DateTime(2021, 2, 10, 23, 56, 13, 448, DateTimeKind.Local).AddTicks(9345), null, "Cássio Morais", "senhateste@", 1 });
        }
    }
}
