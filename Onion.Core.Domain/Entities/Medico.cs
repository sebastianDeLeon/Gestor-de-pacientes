
using Gestor.Core.Domain.Common;

namespace Gestor.Core.Domain.Entities
{
    public class Medico : AuditableBaseEntity
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string correo { get; set; }
        public long cedula { get; set; }
        public long telefono { get; set; }

        public string? foto { get; set; }

        //navigation property

        public ICollection<Citas>? citas { get; set; }
    }
}
