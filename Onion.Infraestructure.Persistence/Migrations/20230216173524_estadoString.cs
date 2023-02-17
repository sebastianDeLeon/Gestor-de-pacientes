using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestor.Infrastructure.Persistence.Migrations
{
    public partial class estadoString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_citas_estadoCitas_estadoId",
                table: "citas");

            migrationBuilder.DropIndex(
                name: "IX_citas_estadoId",
                table: "citas");

            migrationBuilder.AlterColumn<string>(
                name: "estadoId",
                table: "citas",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<int>(
                name: "EstadoCitaId",
                table: "citas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_citas_EstadoCitaId",
                table: "citas",
                column: "EstadoCitaId");

            migrationBuilder.AddForeignKey(
                name: "FK_citas_estadoCitas_EstadoCitaId",
                table: "citas",
                column: "EstadoCitaId",
                principalTable: "estadoCitas",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_citas_estadoCitas_EstadoCitaId",
                table: "citas");

            migrationBuilder.DropIndex(
                name: "IX_citas_EstadoCitaId",
                table: "citas");

            migrationBuilder.DropColumn(
                name: "EstadoCitaId",
                table: "citas");

            migrationBuilder.AlterColumn<int>(
                name: "estadoId",
                table: "citas",
                type: "int",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.CreateIndex(
                name: "IX_citas_estadoId",
                table: "citas",
                column: "estadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_citas_estadoCitas_estadoId",
                table: "citas",
                column: "estadoId",
                principalTable: "estadoCitas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
