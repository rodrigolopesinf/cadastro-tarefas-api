using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cadastro.Tarefas.Core.Migrations
{
    public partial class AjusteColunaDataCriacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.RenameTable(
                name: "Tarefas",
                newName: "Tarefas",
                newSchema: "dbo");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                schema: "dbo",
                table: "Tarefas",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Tarefas",
                schema: "dbo",
                newName: "Tarefas");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Tarefas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
