using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestor.Core.Domain.Common;
namespace Gestor.Core.Domain.Entities
{
    public class Citas : AuditableBaseEntity
    {
        //sistema(se debe mostrar en este listado Nombre del paciente,Nombre del médico,
        //fecha de la cita, hora de la cita, causa de la cita y estado de la cita),
        
        public DateTime Fecha_hora { get; set; }
        public string motivo { get; set; }
        public bool estadoResultado { get; set; }
        public bool citaCompletada { get; set; }

        //fk
        public int pacienteId { get; set; }
        public int medicoId { get; set; }

        //navigation property
        public Pacientes? Pacientes { get; set; }
        public Medico? Medico { get; set; }
        public EstadoCita? EstadoCita { get; set; }

        public ICollection<ResultadoLaboratorio>? resultadoLaboratorio { get; set; }
    }
}
