using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace api.Migrations
{
    public partial class alteraLogradouro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Complemento",
                table: "Enderecos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: -1,
                column: "DiaDeNascimento",
                value: new DateTime(2021, 2, 11, 22, 43, 35, 169, DateTimeKind.Local).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "Enderecos",
                keyColumn: "Id",
                keyValue: -1,
                column: "Complemento",
                value: null);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Complemento",
                table: "Enderecos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: -1,
                column: "DiaDeNascimento",
                value: new DateTime(2021, 2, 11, 22, 42, 30, 364, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "Enderecos",
                keyColumn: "Id",
                keyValue: -1,
                column: "Complemento",
                value: 0);
        }
    }
}
