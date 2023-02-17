using Gestor.Core.Application.ViewModel.EstadoCita;
using Gestor.Core.Application.ViewModel.Medico;
using Gestor.Core.Application.ViewModel.Paciente;
using Gestor.Core.Application.ViewModel.PruebasLaboratorio;

namespace Gestor.Core.Application.ViewModel.Citas
{
    public class SaveCitasViewModel
    {
        public int Id { get; set; }
        public DateTime Fecha_hora { get; set; }
        public string motivo { get; set; }

        public bool estadoResultado { get; set; }
        public bool citaCompletada { get; set; }

        //fk
        public int pacienteId { get; set; }
        public int medicoId { get; set; }

        //navigation property
        public SavePacienteViewModel? pacientes { get; set; }
        public SaveMedicoViewModel? medico { get; set; }
        public SaveEstadoCitaViewModel? EstadoCita { get; set; }

        public List<PacienteViewModel>? pacientesList { get; set; }
        public List<MedicoViewModel>? medicoList { get; set; }
        public List<PruebasLabViewModel>? pruebasLaboratorios { get; set; }

    }
}
