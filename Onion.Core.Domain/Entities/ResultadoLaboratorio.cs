using Gestor.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor.Core.Domain.Entities
{
    public class ResultadoLaboratorio : AuditableBaseEntity
    {
        public string? resultado { get; set; }
        public bool completado { get; set; }
        //fk
        public int pruebaId { get; set; }
        public int pacienteId { get; set; }
        public int CitaId { get; set; }
        //navigation property
        public Pacientes? pacientes { get; set; }
        public PruebasLaboratorio? pruebas { get; set; }
    }
}
