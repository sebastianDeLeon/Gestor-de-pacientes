using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor.Core.Application.ViewModel.Paciente
{
    public class PacienteViewModel
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public long telefono { get; set; }
        public string direccion { get; set; }
        public long cedula { get; set; }
        public DateTime fecha_de_nacimiento { get; set; }
        public bool fumador { get; set; }
        public bool alergico { get; set; }

        public string? foto { get; set; }
    }
}
