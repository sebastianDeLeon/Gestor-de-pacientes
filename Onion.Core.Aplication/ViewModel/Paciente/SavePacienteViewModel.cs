using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor.Core.Application.ViewModel.Paciente
{
    public class SavePacienteViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Debe llenar esta campo")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Debe llenar esta campo")]
        public string apellido { get; set; }

        [Required(ErrorMessage = "Debe llenar esta campo")]
        public long telefono { get; set; }

        [Required(ErrorMessage = "Debe llenar esta campo")]
        public string direccion { get; set; }

        [Required(ErrorMessage = "Debe llenar esta campo")]
        public long cedula { get; set; }

        [Required(ErrorMessage = "Debe llenar esta campo")]
        public DateTime fecha_de_nacimiento { get; set; }

        [Required(ErrorMessage = "Debe llenar esta campo")]
        public bool fumador { get; set; }

        [Required(ErrorMessage = "Debe llenar esta campo")]
        public bool alergico { get; set; }

        [Required(ErrorMessage = "Debe llenar esta campo")]
        public string? foto { get; set; }
    }
}
