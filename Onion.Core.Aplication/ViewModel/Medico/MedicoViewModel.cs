using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor.Core.Application.ViewModel.Medico
{
    public class MedicoViewModel
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string correo { get; set; }
        public long cedula { get; set; }
        public long telefono { get; set; }

        public string? foto { get; set; }
    }
}
