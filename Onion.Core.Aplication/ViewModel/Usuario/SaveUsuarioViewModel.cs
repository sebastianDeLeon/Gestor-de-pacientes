using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor.Core.Application.ViewModel.Usuario
{
    public class SaveUsuarioViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe ingresar el nombre")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "Debe ingresar el apellido")]
        public string apellido { get; set; }
        [Required(ErrorMessage = "Debe ingresar el correo")]
        public string correo { get; set; }
        [Required(ErrorMessage = "Debe ingresar la contraseña")]
        public string password { get; set; }
        [Required(ErrorMessage = "Debe ingresar el nombre del usuario")]
        public string Nombre_de_usuario { get; set; }
        [Required(ErrorMessage = "Debe clarar si el usuario es admin")]
        public bool Admin { get; set; }
    }
}
