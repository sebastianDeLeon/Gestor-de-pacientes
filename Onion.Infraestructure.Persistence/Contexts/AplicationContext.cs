using Gestor.Core.Domain.Common;
using Gestor.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor.Infraestructure.Persistence.Contexts
{
    public class AplicationContext : DbContext
    {
        public AplicationContext(DbContextOptions<AplicationContext> options) : base(options) { }

        #region DbSets
        public DbSet<Citas> citas { get; set; }

        public DbSet<EstadoCita> estadoCitas { get; set; }

        public DbSet<Medico> medico { get; set; }

        public DbSet<Pacientes> pacientes { get; set; }

        public DbSet<PruebasLaboratorio> pruebasLaboratorios { get; set; }

        public DbSet<ResultadoLaboratorio> resultadoLaboratorios { get; set; }

        public DbSet<Usuario> usuarios { get; set; }
        #endregion

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableBaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.Created = DateTime.Now;
                        entry.Entity.CreatedBy = "DefaultAppUser";
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModified = DateTime.Now;
                        entry.Entity.LastModifiedBy = "DefaultAppUser";
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Primary Keys
            modelBuilder.Entity<Citas>()
                .HasKey(product => product.Id);

            modelBuilder.Entity<EstadoCita>()
                .HasKey(product => product.Id);

            modelBuilder.Entity<Medico>()
                .HasKey(product => product.Id);

            modelBuilder.Entity<Pacientes>()
                .HasKey(product => product.Id);

            modelBuilder.Entity<PruebasLaboratorio>()
                .HasKey(product => product.Id);

            modelBuilder.Entity<ResultadoLaboratorio>()
                .HasKey(product => product.Id);

            modelBuilder.Entity<Usuario>()
                .HasKey(product => product.Id);
            #endregion

            #region Realtions

            #region Citas
            //modelBuilder.Entity<Citas>()
            //    .HasMany<ResultadoLaboratorio>(r => r.Resultado)
            //    .WithOne(citas => citas.citas)
            //    .HasForeignKey(citas => citas.citaId)
            //    .OnDelete(DeleteBehavior.Cascade);
            #endregion

            #region PruebasLaboratorio
            modelBuilder.Entity<PruebasLaboratorio>()
                .HasMany<ResultadoLaboratorio>(resul => resul.resultadoLaboratorios)
                .WithOne(prueba => prueba.pruebas)
                .HasForeignKey(product => product.pruebaId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion

            #region cita
            modelBuilder.Entity<Citas>()
                .HasMany<ResultadoLaboratorio>(cita => cita.resultadoLaboratorio)
                .WithOne(r => r.citas)
                .HasForeignKey(product => product.CitaId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion

            #region Medico
            modelBuilder.Entity<Medico>()
                .HasMany<Citas>(resul => resul.citas)
                .WithOne(prueba => prueba.Medico)
                .HasForeignKey(product => product.medicoId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion

            #region Pacientes
            modelBuilder.Entity<Pacientes>()
                .HasMany<ResultadoLaboratorio>(paciente => paciente.resultados)
                .WithOne(resul => resul.pacientes)
                .HasForeignKey(resul => resul.pacienteId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Pacientes>()
                .HasMany<Citas>(resul => resul.citas)
                .WithOne(prueba => prueba.Pacientes)
                .HasForeignKey(product => product.pacienteId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion

            #endregion


            #region Indexes
            modelBuilder.Entity<Medico>()
                .HasIndex(medico => medico.cedula)
                .IsUnique();

            modelBuilder.Entity<Usuario>()
                .HasIndex(usuario => usuario.Nombre_de_usuario)
                .IsUnique();

            modelBuilder.Entity<Medico>()
                .HasIndex(medico => medico.cedula)
                .IsUnique();
            #endregion     

            #region "Property configurations"

            #region Medico

            modelBuilder.Entity<Medico>().
                Property(product => product.nombre)
                .IsRequired();

            modelBuilder.Entity<Medico>().
                Property(product => product.apellido)
                .IsRequired();

            modelBuilder.Entity<Medico>().
                Property(product => product.cedula)
                .IsRequired();

            modelBuilder.Entity<Medico>().
                Property(product => product.correo)
                .IsRequired();

            modelBuilder.Entity<Medico>().
                Property(product => product.telefono)
                .IsRequired();



            #endregion

            #region pacientes
            modelBuilder.Entity<Pacientes>().
              Property(pacientes => pacientes.nombre)
              .IsRequired()
              .HasMaxLength(100);

            modelBuilder.Entity<Pacientes>().
              Property(pacientes => pacientes.apellido)
              .IsRequired()
              .HasMaxLength(100);

            modelBuilder.Entity<Pacientes>().
              Property(pacientes => pacientes.cedula)
              .IsRequired()
              .HasMaxLength(100);

            modelBuilder.Entity<Pacientes>().
              Property(pacientes => pacientes.alergico)
              .IsRequired()
              .HasMaxLength(100);

            modelBuilder.Entity<Pacientes>().
              Property(pacientes => pacientes.fumador)
              .IsRequired()
              .HasMaxLength(100);

            modelBuilder.Entity<Pacientes>().
              Property(pacientes => pacientes.telefono)
              .IsRequired()
              .HasMaxLength(100);

            modelBuilder.Entity<Pacientes>().
              Property(pacientes => pacientes.fecha_de_nacimiento)
              .IsRequired()
              .HasMaxLength(100);

            modelBuilder.Entity<Pacientes>().
              Property(pacientes => pacientes.direccion)
              .IsRequired()
              .HasMaxLength(100);

            modelBuilder.Entity<Pacientes>().
              Property(pacientes => pacientes.foto)
              .IsRequired()
              .HasMaxLength(100);
            #endregion

            #region Citas
           
            modelBuilder.Entity<Citas>().
              Property(cita => cita.pacienteId)
              .IsRequired()
              .HasMaxLength(100);

            modelBuilder.Entity<Citas>().
              Property(cita => cita.medicoId)
              .IsRequired()
              .HasMaxLength(100);

            modelBuilder.Entity<Citas>().
              Property(cita => cita.motivo)
              .IsRequired()
              .HasMaxLength(450);

            modelBuilder.Entity<Citas>().
              Property(cita => cita.Fecha_hora)
              .IsRequired()
              .HasMaxLength(100);

            #endregion

            #region Estado cita

            modelBuilder.Entity<EstadoCita>().
              Property(estado => estado.estadoCita)
              .IsRequired()
              .HasMaxLength(100);

            #endregion

            #region Usuario

            modelBuilder.Entity<Usuario>().
              Property(usuario => usuario.nombre)
              .IsRequired()
              .HasMaxLength(100);

            modelBuilder.Entity<Usuario>().
              Property(usuario => usuario.apellido)
              .IsRequired()
              .HasMaxLength(100);

            modelBuilder.Entity<Usuario>().
              Property(usuario => usuario.Nombre_de_usuario)
              .IsRequired()
              .HasMaxLength(100);

            modelBuilder.Entity<Usuario>().
              Property(usuario => usuario.password)
              .IsRequired()
              .HasMaxLength(100);

            modelBuilder.Entity<Usuario>().
              Property(usuario => usuario.correo)
              .IsRequired()
              .HasMaxLength(100);

            #endregion

            #region Pruebas laboratiorio

            modelBuilder.Entity<PruebasLaboratorio>().
              Property(prueba => prueba.nombre_prueba)
              .IsRequired()
              .HasMaxLength(100);

            #endregion

            #region Resultado laboratorio

            modelBuilder.Entity<ResultadoLaboratorio>().
              Property(estado => estado.pruebaId)
              .IsRequired()
              .HasMaxLength(100);

            modelBuilder.Entity<ResultadoLaboratorio>().
              Property(estado => estado.resultado)
              .HasMaxLength(450);

            modelBuilder.Entity<ResultadoLaboratorio>().
              Property(estado => estado.pacienteId)
              .IsRequired()
              .HasMaxLength(100);

            modelBuilder.Entity<ResultadoLaboratorio>().
              Property(estado => estado.completado)
              .IsRequired()
              .HasMaxLength(100);

            #endregion

            #endregion
        }
    }
}
