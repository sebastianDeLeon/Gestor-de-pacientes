﻿// <auto-generated />
using System;
using Gestor.Infraestructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gestor.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(AplicationContext))]
    [Migration("20230217080930_resultadoNull2")]
    partial class resultadoNull2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Gestor.Core.Domain.Entities.Citas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EstadoCitaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha_hora")
                        .HasMaxLength(100)
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("citaCompletada")
                        .HasColumnType("bit");

                    b.Property<bool>("estadoResultado")
                        .HasColumnType("bit");

                    b.Property<int>("medicoId")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<string>("motivo")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("pacienteId")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EstadoCitaId");

                    b.HasIndex("medicoId");

                    b.HasIndex("pacienteId");

                    b.ToTable("citas");
                });

            modelBuilder.Entity("Gestor.Core.Domain.Entities.EstadoCita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estadoCita")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("estadoCitas");
                });

            modelBuilder.Entity("Gestor.Core.Domain.Entities.Medico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("cedula")
                        .HasColumnType("bigint");

                    b.Property<string>("correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("telefono")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("cedula")
                        .IsUnique();

                    b.ToTable("medico");
                });

            modelBuilder.Entity("Gestor.Core.Domain.Entities.Pacientes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("alergico")
                        .HasMaxLength(100)
                        .HasColumnType("bit");

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<long>("cedula")
                        .HasMaxLength(100)
                        .HasColumnType("bigint");

                    b.Property<string>("direccion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("fecha_de_nacimiento")
                        .HasMaxLength(100)
                        .HasColumnType("datetime2");

                    b.Property<string>("foto")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("fumador")
                        .HasMaxLength(100)
                        .HasColumnType("bit");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<long>("telefono")
                        .HasMaxLength(100)
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("pacientes");
                });

            modelBuilder.Entity("Gestor.Core.Domain.Entities.PruebasLaboratorio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre_prueba")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("pruebasLaboratorios");
                });

            modelBuilder.Entity("Gestor.Core.Domain.Entities.ResultadoLaboratorio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("completado")
                        .HasMaxLength(100)
                        .HasColumnType("bit");

                    b.Property<int>("pacienteId")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<int>("pruebaId")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<string>("resultado")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("pacienteId");

                    b.HasIndex("pruebaId");

                    b.ToTable("resultadoLaboratorios");
                });

            modelBuilder.Entity("Gestor.Core.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Admin")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre_de_usuario")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("correo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Nombre_de_usuario")
                        .IsUnique();

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("Gestor.Core.Domain.Entities.Citas", b =>
                {
                    b.HasOne("Gestor.Core.Domain.Entities.EstadoCita", "EstadoCita")
                        .WithMany("Citas")
                        .HasForeignKey("EstadoCitaId");

                    b.HasOne("Gestor.Core.Domain.Entities.Medico", "Medico")
                        .WithMany("citas")
                        .HasForeignKey("medicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gestor.Core.Domain.Entities.Pacientes", "Pacientes")
                        .WithMany("citas")
                        .HasForeignKey("pacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EstadoCita");

                    b.Navigation("Medico");

                    b.Navigation("Pacientes");
                });

            modelBuilder.Entity("Gestor.Core.Domain.Entities.ResultadoLaboratorio", b =>
                {
                    b.HasOne("Gestor.Core.Domain.Entities.Pacientes", "pacientes")
                        .WithMany("resultados")
                        .HasForeignKey("pacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gestor.Core.Domain.Entities.PruebasLaboratorio", "pruebas")
                        .WithMany("resultadoLaboratorios")
                        .HasForeignKey("pruebaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("pacientes");

                    b.Navigation("pruebas");
                });

            modelBuilder.Entity("Gestor.Core.Domain.Entities.EstadoCita", b =>
                {
                    b.Navigation("Citas");
                });

            modelBuilder.Entity("Gestor.Core.Domain.Entities.Medico", b =>
                {
                    b.Navigation("citas");
                });

            modelBuilder.Entity("Gestor.Core.Domain.Entities.Pacientes", b =>
                {
                    b.Navigation("citas");

                    b.Navigation("resultados");
                });

            modelBuilder.Entity("Gestor.Core.Domain.Entities.PruebasLaboratorio", b =>
                {
                    b.Navigation("resultadoLaboratorios");
                });
#pragma warning restore 612, 618
        }
    }
}
