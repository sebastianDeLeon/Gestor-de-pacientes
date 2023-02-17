using Gestor.Core.Application.Interfaces.Services;
using Gestor.Core.Application.ViewModel.EstadoCita;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor.Core.Application.Services
{
    public class EstadoCitaService : IEstadoCitaService
    {
        public Task Add(SaveEstadoCitaViewModel vm)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id )
        {
            throw new NotImplementedException();
        }

        public Task<List<EstadoCitaVireModel>> GetAllViewModel()
        {
            throw new NotImplementedException();
        }

        public Task<SaveEstadoCitaViewModel> GetByIdSaveViewModel(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(SaveEstadoCitaViewModel vm)
        {
            throw new NotImplementedException();
        }
    }
}
