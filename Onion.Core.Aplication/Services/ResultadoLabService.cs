using Gestor.Core.Application.Interfaces.Services;
using Gestor.Core.Application.Interfaces.Repositories;
using Gestor.Core.Application.ViewModel.ResultadoLaboratorio;
using Gestor.Core.Domain.Entities;

namespace Gestor.Core.Application.Services
{
    public class ResultadoLabService : IResultadoLabService
    {
        private readonly IResultadoLabRepository _resultado;
        private readonly IPruebaLabRepository _prueba;

        public ResultadoLabService(IResultadoLabRepository resultadoLabService,
            IPruebaLabRepository prueba)
        {
            _resultado = resultadoLabService;
            _prueba = prueba;
        }
        ResultadoLaboratorio r = new();
        public async Task Add(SaveResultLabViewModel vm)
        {
            r.completado = vm.completado;
            r.pacienteId = vm.pacienteId;
            r.pruebaId = vm.pruebaId;
            r.resultado = vm.resultado;
            await _resultado.AddAsync(r);
        }

        public async Task Delete(int id)
        {
            var resulId = await _resultado.GetByIdAsync(id);
            await _resultado.DeleteAsync(resulId);
        }

        public async Task<List<ResultLabViewModel>> GetAllViewModel()
        {
            var listaRes = await _resultado.GetAllAsync();
            return listaRes.Select(u => new ResultLabViewModel
            {
                Id = u.Id,
                resultado = u.resultado,
                completado = u.completado,
                pacienteId = u.pacienteId,
                pruebaId = u.pruebaId,
            }).ToList();
        }

        public async Task<SaveResultLabViewModel> GetByIdSaveViewModel(int id)
        {
            var result = await _resultado.GetByIdAsync(id);
            SaveResultLabViewModel resultLab = new SaveResultLabViewModel();
            resultLab.Id = result.Id;
            resultLab.resultado = result.resultado;
            resultLab.completado = result.completado;
            resultLab.pacienteId= result.pacienteId;
            resultLab.pruebaId= result.pruebaId;
            return resultLab;
        }

        public async Task Update(SaveResultLabViewModel vm)
        {
            r.Id = vm.Id;
            r.completado = vm.completado;
            r.pacienteId = vm.pacienteId;
            r.pruebaId = vm.pruebaId;
            r.resultado = vm.resultado;
            await _resultado.UpdateAsync(r);
        }
    }
}
