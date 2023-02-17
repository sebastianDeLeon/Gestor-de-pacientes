using Gestor.Core.Domain.Common;

namespace Gestor.Core.Domain.Entities
{
    public class PruebasLaboratorio : AuditableBaseEntity
    {
        public string nombre_prueba { get; set; }

        //navigation
        public ICollection<ResultadoLaboratorio>? resultadoLaboratorios;
    }
}
