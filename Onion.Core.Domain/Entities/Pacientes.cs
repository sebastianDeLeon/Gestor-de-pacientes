using Gestor.Core.Domain.Common;

namespace Gestor.Core.Domain.Entities
{
    public class Pacientes : AuditableBaseEntity
    {
        //Nombre, apellido, teléfono, dirección, cédula, fecha de nacimiento, si
        //es fumador, si tiene alergias, foto y un botón para crear el paciente.
        public string nombre { get; set; }
        public string apellido { get; set; }
        public long telefono { get; set; }
        public string direccion { get; set; }
        public long cedula { get; set; }
        public DateTime fecha_de_nacimiento{ get; set; }
        public bool fumador { get; set; }
        public bool alergico { get; set; }

        public string? foto{ get; set; }

        //navigation property

        public ICollection<Citas>? citas { get; set; }
        public ICollection<ResultadoLaboratorio>? resultados { get; set; }

    }
}
