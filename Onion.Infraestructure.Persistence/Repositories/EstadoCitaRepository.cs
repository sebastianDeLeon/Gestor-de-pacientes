using Gestor.Core.Application.Interfaces.Repositories;
using Gestor.Core.Domain.Entities;
using Gestor.Infraestructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor.Infrastructure.Persistence.Repositories
{
    public class EstadoCitaRepository : GenericRepository<EstadoCita>, IEstadoCitaRepository
    {
        private readonly AplicationContext _context;
        public EstadoCitaRepository(AplicationContext aplicationContext) : base(aplicationContext)
        {
            _context = aplicationContext;
        }
    }
}
