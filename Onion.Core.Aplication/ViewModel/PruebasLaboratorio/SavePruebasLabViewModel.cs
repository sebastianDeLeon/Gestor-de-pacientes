using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor.Core.Application.ViewModel.PruebasLaboratorio
{
    public class SavePruebasLabViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe colocar el nombre de la prueba")]
        public string nombre_prueba { get; set; }
    }
}
