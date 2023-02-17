using Gestor.Core.Application.Interfaces.Services;
using Gestor.Core.Application.ViewModel.ResultadoLaboratorio;
using Microsoft.AspNetCore.Mvc;

namespace Gestor.Controllers
{
    public class ResultadoController : Controller
    {
        private readonly IResultadoLabService _resultado;
        private readonly IPruebaLabService _prueba;
        private readonly IPacientesService _paciente;
        private readonly ICitasService _cita;

        public ResultadoController(IResultadoLabService pruebaLabService,
            IPruebaLabService prueba, IPacientesService paciente, ICitasService cita)
        {
            _resultado = pruebaLabService;
            _prueba = prueba;
            _paciente = paciente;
        }
        public async Task<IActionResult> Index()
        {
            var resultados = await _resultado.GetAllViewModel();
            List<ResultLabViewModel> reslis = new List<ResultLabViewModel>();

            foreach(ResultLabViewModel r in resultados)
            {
                r.pacientes=await _paciente.GetByIdSaveViewModel(r.pacienteId);
                r.pruebas=await _prueba.GetByIdSaveViewModel(r.pruebaId);
                reslis.Add(r);
            }
            return View("Index", resultados);
        }
        [HttpPost]
        public async Task<IActionResult> AddF(int pacienteId)
        {
            SaveResultLabViewModel vm = new SaveResultLabViewModel();
            vm.pruebasList =  await _prueba.GetAllViewModel();
            vm.pacientes = await _paciente.GetByIdSaveViewModel(pacienteId);
            //List<SaveResultLabViewModel> lista = new List<SaveResultLabViewModel>();
            //lista.Add(vm);
            return View("SaveResultados", vm);
        }
        [HttpPost]
        public async Task<IActionResult> Add(SaveResultLabViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View("SaveResultados", vm);
            }
            await _resultado.Add(vm);
           
            return RedirectToRoute(new { controller = "Resultado", action = "Index" });
        }

        public async Task<IActionResult> Edit(int id)
        {
            return View("SaveResult", await _resultado.GetByIdSaveViewModel(id));
        }
        [HttpPost]
        public async Task<IActionResult> Edit(SaveResultLabViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View("SaveResult", vm);
            }

            await _resultado.Update(vm);
            return RedirectToRoute(new { controller = "Resultado", action = "Index" });
        }
        public async Task<IActionResult> Delete(int id)
        {
            return View("DeleteResult", await _resultado.GetByIdSaveViewModel(id));
        }
        [HttpPost]
        public async Task<IActionResult> DeletePost(int id)
        {

            await _resultado.Delete(id);
            return RedirectToRoute(new { controller = "Resultado", action = "Index" });
        }
    }
}
