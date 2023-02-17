using Gestor.Core.Application.Interfaces.Services;
using Gestor.Core.Application.ViewModel.Citas;
using Gestor.Core.Application.ViewModel.EstadoCita;
using Microsoft.AspNetCore.Mvc;

namespace Gestor.Controllers
{
    public class CitasController : Controller
    {
        private readonly ICitasService _cita;
        //private readonly IEstadoCitaService _estado;
        private readonly IPruebaLabService _preba;
        private readonly IPacientesService _pacientes;
        private readonly IMedicoService _medico;

        public CitasController(ICitasService pruebaLabService, 
            IPacientesService pacientes, IPruebaLabService prueba,
            IMedicoService medico)
        {
            _cita = pruebaLabService;
            _pacientes = pacientes;
            _preba = prueba;
            _medico = medico;
        }
        public async Task<IActionResult> Index()
        {
            //var estados = _estado.GetAllViewModel();
            //if(estados != null)
            //{
            //    SaveEstadoCitaViewModel saveEstado = new();
            //    await _estado.Add(new SaveEstadoCitaViewModel {estadoCita= "pendiente de consulta" });
            //    await _estado.Add(new SaveEstadoCitaViewModel { estadoCita = "pendiente de resultados" });
            //    await _estado.Add(new SaveEstadoCitaViewModel { estadoCita = "completada" });
            //}
            
            return View("Index", await _cita.GetAllViewModel());
        }
        public async Task<IActionResult> Add()
        {
            SaveCitasViewModel vm = new SaveCitasViewModel();
            vm.medicoList = await _medico.GetAllViewModel();
            vm.pacientesList = await _pacientes.GetAllViewModel();
            vm.pruebasLaboratorios = await _preba.GetAllViewModel();
            return View("SaveCitas", vm);
        }
        [HttpPost]
        public async Task<IActionResult> Add(SaveCitasViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View("SavePruebas", vm);
            }
            await _cita.Add(vm);
            return RedirectToRoute(new { controller = "Citas", action = "Index" });
        }

        public async Task<IActionResult> Edit(int id)
        {
            return View("SaveCitas", await _cita.GetByIdSaveViewModel(id));
        }
        [HttpPost]
        public async Task<IActionResult> Edit(SaveCitasViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View("SaveCitas", vm);
            }

            await _cita.Update(vm);
            return RedirectToRoute(new { controller = "Citas", action = "Index" });
        }
        public async Task<IActionResult> Delete(int id)
        {
            return View("DeleteCitas", await _cita.GetByIdSaveViewModel(id));
        }
        [HttpPost]
        public async Task<IActionResult> DeletePost(int id)
        {
            await _cita.Delete(id);
            return RedirectToRoute(new { controller = "Citas", action = "Index" });
        }
    }
}
