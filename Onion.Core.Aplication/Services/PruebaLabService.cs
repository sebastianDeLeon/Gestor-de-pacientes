using Gestor.Core.Application.Interfaces.Repositories;
using Gestor.Core.Application.Interfaces.Services;
using Gestor.Core.Application.ViewModel.PruebasLaboratorio;
using Gestor.Core.Domain.Entities;

namespace Gestor.Core.Application.Services
{
    public class PruebaLabService : IPruebaLabService
    {
        private readonly IPruebaLabRepository _prueba;

        public PruebaLabService(IPruebaLabRepository pruebaLabRepository)
        {
            _prueba = pruebaLabRepository;
        }
        public async Task Add(SavePruebasLabViewModel vm)
        {
            PruebasLaboratorio prueba = new();
            prueba.nombre_prueba = vm.nombre_prueba;
            
            await _prueba.AddAsync(prueba);
        }

        public async Task Delete(int id)
        {
            var prueba = await _prueba.GetByIdAsync(id);
            await _prueba.DeleteAsync(prueba);
        }

        public async Task<List<PruebasLabViewModel>> GetAllViewModel()
        {
            var pruebas = await _prueba.GetAllAsync();

            return pruebas.Select(pr => new PruebasLabViewModel
            {
                id = pr.Id,
                nombre_prueba=pr.nombre_prueba
            }).ToList();


        }

        public async Task<SavePruebasLabViewModel> GetByIdSaveViewModel(int id)
        {
            var prueba = await _prueba.GetByIdAsync(id);
            SavePruebasLabViewModel viewModel = new SavePruebasLabViewModel();
            viewModel.Id = prueba.Id;
            viewModel.nombre_prueba = prueba.nombre_prueba;
            return viewModel;
        }

        public async Task Update(SavePruebasLabViewModel vm)
        {
            PruebasLaboratorio prueba = new();
            prueba.nombre_prueba = vm.nombre_prueba;
            prueba.Id = vm.Id;
            await _prueba.UpdateAsync(prueba);
        }
    }
}
