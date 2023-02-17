using Gestor.Core.Application.ViewModel.Paciente;
using Gestor.Core.Application.ViewModel.PruebasLaboratorio;
using Gestor.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor.Core.Application.ViewModel.ResultadoLaboratorio
{
    public class ResultLabViewModel
    {
        public int Id { get; set; }
        public string? resultado { get; set; }
        public bool completado { get; set; }
        //fk
        public int pruebaId { get; set; }
        public int pacienteId { get; set; }
        //navigation property
        public SavePacienteViewModel? pacientes { get; set; }
        public SavePruebasLabViewModel? pruebas { get; set; }
    }
}
