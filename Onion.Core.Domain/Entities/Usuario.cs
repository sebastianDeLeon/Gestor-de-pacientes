
using Gestor.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor.Core.Domain.Entities
{
    public class Usuario : AuditableBaseEntity
    {
        //Nombre, Apellido,Correo, Nombre de usuario, Contraseña
        public  string nombre { get; set; }
        public string apellido { get; set; }
        public string correo { get; set; }
        public string password { get; set; }
        public string Nombre_de_usuario { get; set; }

        // En caso de ser cierto significa que es admin
        public bool Admin { get; set; }

        //navigation property
    }
}
