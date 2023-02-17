using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestor.Infrastructure.Persistence.Migrations
{
    public partial class boolCitas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "estadoId",
                table: "citas");

            migrationBuilder.DropColumn(
                name: "pruebaId",
                table: "citas");

            migrationBuilder.AddColumn<bool>(
                name: "citaCompletada",
                table: "citas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "estadoResultado",
                table: "citas",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "citaCompletada",
                table: "citas");

            migrationBuilder.DropColumn(
                name: "estadoResultado",
                table: "citas");

            migrationBuilder.AddColumn<string>(
                name: "estadoId",
                table: "citas",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "pruebaId",
                table: "citas",
                type: "int",
                maxLength: 100,
                nullable: false,
                defaultValue: 0);
        }
    }
}
