using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestor.Infrastructure.Persistence.Migrations
{
    public partial class begin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "estadoCitas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    estadoCita = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estadoCitas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "medico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cedula = table.Column<long>(type: "bigint", nullable: false),
                    telefono = table.Column<long>(type: "bigint", nullable: false),
                    foto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "pacientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    telefono = table.Column<long>(type: "bigint", maxLength: 100, nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    cedula = table.Column<long>(type: "bigint", maxLength: 100, nullable: false),
                    fecha_de_nacimiento = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: false),
                    fumador = table.Column<bool>(type: "bit", maxLength: 100, nullable: false),
                    alergico = table.Column<bool>(type: "bit", maxLength: 100, nullable: false),
                    foto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pacientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "pruebasLaboratorios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_prueba = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pruebasLaboratorios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    correo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Nombre_de_usuario = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Admin = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "citas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha_hora = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: false),
                    motivo = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    pruebaId = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    pacienteId = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    medicoId = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    estadoId = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_citas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_citas_estadoCitas_estadoId",
                        column: x => x.estadoId,
                        principalTable: "estadoCitas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_citas_medico_medicoId",
                        column: x => x.medicoId,
                        principalTable: "medico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_citas_pacientes_pacienteId",
                        column: x => x.pacienteId,
                        principalTable: "pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "resultadoLaboratorios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    resultado = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    completado = table.Column<bool>(type: "bit", maxLength: 100, nullable: false),
                    pruebaId = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    pacienteId = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resultadoLaboratorios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_resultadoLaboratorios_pacientes_pacienteId",
                        column: x => x.pacienteId,
                        principalTable: "pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_resultadoLaboratorios_pruebasLaboratorios_pruebaId",
                        column: x => x.pruebaId,
                        principalTable: "pruebasLaboratorios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_citas_estadoId",
                table: "citas",
                column: "estadoId");

            migrationBuilder.CreateIndex(
                name: "IX_citas_medicoId",
                table: "citas",
                column: "medicoId");

            migrationBuilder.CreateIndex(
                name: "IX_citas_pacienteId",
                table: "citas",
                column: "pacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_medico_cedula",
                table: "medico",
                column: "cedula",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_resultadoLaboratorios_pacienteId",
                table: "resultadoLaboratorios",
                column: "pacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_resultadoLaboratorios_pruebaId",
                table: "resultadoLaboratorios",
                column: "pruebaId");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_Nombre_de_usuario",
                table: "usuarios",
                column: "Nombre_de_usuario",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "citas");

            migrationBuilder.DropTable(
                name: "resultadoLaboratorios");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "estadoCitas");

            migrationBuilder.DropTable(
                name: "medico");

            migrationBuilder.DropTable(
                name: "pacientes");

            migrationBuilder.DropTable(
                name: "pruebasLaboratorios");
        }
    }
}
