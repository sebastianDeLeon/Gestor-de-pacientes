
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestor.Core.Domain.Common;

namespace Gestor.Core.Domain.Entities
{
    public class EstadoCita : AuditableBaseEntity
    {
        public string estadoCita { get; set; }

        //navigation
        public ICollection<Citas> Citas { get; set; }
    }
}
