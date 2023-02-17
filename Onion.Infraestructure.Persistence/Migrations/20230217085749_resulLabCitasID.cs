using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestor.Infrastructure.Persistence.Migrations
{
    public partial class resulLabCitasID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CitaId",
                table: "resultadoLaboratorios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_resultadoLaboratorios_CitaId",
                table: "resultadoLaboratorios",
                column: "CitaId");

            migrationBuilder.AddForeignKey(
                name: "FK_resultadoLaboratorios_citas_CitaId",
                table: "resultadoLaboratorios",
                column: "CitaId",
                principalTable: "citas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_resultadoLaboratorios_citas_CitaId",
                table: "resultadoLaboratorios");

            migrationBuilder.DropIndex(
                name: "IX_resultadoLaboratorios_CitaId",
                table: "resultadoLaboratorios");

            migrationBuilder.DropColumn(
                name: "CitaId",
                table: "resultadoLaboratorios");
        }
    }
}
