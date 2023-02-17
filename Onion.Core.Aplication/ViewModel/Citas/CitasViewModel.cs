using Gestor.Core.Application.ViewModel.EstadoCita;
using Gestor.Core.Application.ViewModel.Medico;
using Gestor.Core.Application.ViewModel.Paciente;
using Gestor.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor.Core.Application.ViewModel.Citas
{
    public class CitasViewModel
    {
        public int Id { get; set; }
        public DateTime Fecha_hora { get; set; }
        public string motivo { get; set; }
        public bool estadoResultado { get; set; }
        public bool citaCompletada { get; set; }

        //fk
        public int pacienteId { get; set; }
        public int medicoId { get; set; }
        public string estadoId { get; set; }

        public string? nombreMedico { get; set; }
        public string? nombrePaciente { get; set; }
        //navigation property
        public SavePacienteViewModel? pacientesSv { get; set; }
        public SaveMedicoViewModel? medicoSv { get; set; }

        public PacienteViewModel? pacientesVm { get; set; }
        public MedicoViewModel? medicoVm { get; set; }
        
        public Gestor.Core.Domain.Entities.Medico? medico { get; set; }
        public Gestor.Core.Domain.Entities.Pacientes? paciente { get; set;}
        //listas
        public List<SavePacienteViewModel>? PacientesListSave { get; set; }
        public List<SaveMedicoViewModel>? MedicoListSave { get; set; }
        public List<PacienteViewModel>? PacientesListVm { get; set; }
        public List<MedicoViewModel>? MedicoListVm { get; set; }

        public List<SaveEstadoCitaViewModel>? EstadoCitaList { get; set; }
    }
}
