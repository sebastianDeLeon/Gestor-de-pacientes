using Gestor.Core.Application.Interfaces.Services;
using Gestor.Core.Application.ViewModel.Paciente;
using Microsoft.AspNetCore.Mvc;

namespace Gestor.Controllers
{
    public class PacienteController : Controller
    {
        private readonly IPacientesService _paciente;

        public PacienteController(IPacientesService pruebaLabService)
        {
            _paciente = pruebaLabService;
        }
        public async Task<IActionResult> Index()
        {
            return View("Index", await _paciente.GetAllViewModel());
        }

        public async Task<IActionResult> Add()
        {
            SavePacienteViewModel vm = new SavePacienteViewModel();
            return View("SavePacientes", vm);
        }
        [HttpPost]
        public async Task<IActionResult> Add(SavePacienteViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View("SavePacientes", vm);
            }
            await _paciente.Add(vm);
            return RedirectToRoute(new { controller = "Paciente", action = "Index" });
        }

        public async Task<IActionResult> Edit(int id)
        {
            return View("SavePacientes", await _paciente.GetByIdSaveViewModel(id));
        }
        [HttpPost]
        public async Task<IActionResult> Edit(SavePacienteViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View("SavePacientes", vm);
            }

            await _paciente.Update(vm);
            return RedirectToRoute(new { controller = "Paciente", action = "Index" });
        }
        public async Task<IActionResult> Delete(int id)
        {
            return View("DeletePacientes", await _paciente.GetByIdSaveViewModel(id));
        }
        [HttpPost]
        public async Task<IActionResult> DeletePost(int id)
        {
            await _paciente.Delete(id);
            return RedirectToRoute(new { controller = "Paciente", action = "Index" });
        }
    }
}
