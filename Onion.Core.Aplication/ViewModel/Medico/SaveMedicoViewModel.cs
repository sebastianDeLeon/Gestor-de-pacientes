using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor.Core.Application.ViewModel.Medico
{
    public class SaveMedicoViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe ingresar el nombre")]
        
        public string nombre { get; set; }
        [Required(ErrorMessage = "Debe ingresar el apellido")]

        public string apellido { get; set; }
        
        [Required(ErrorMessage = "Debe ingresar el correo")]
        public string correo { get; set; }
        
        [Required(ErrorMessage = "Debe ingresar el cedula")]
        public long cedula { get; set; }
        
        [Required(ErrorMessage = "Debe ingresar el telefono")]
        public long telefono { get; set; }
        
        [Required(ErrorMessage = "Debe ingresar la foto")]

        public string? foto { get; set; }
    }

}
