using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor.Core.Application.ViewModel.Usuario
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string correo { get; set; }
        public string Nombre_de_usuario { get; set; }
        public bool Admin { get; set; }
    }
}
