using Gestor.Core.Application.Interfaces.Services;
using Gestor.Core.Application.ViewModel.Medico;
using Microsoft.AspNetCore.Mvc;

namespace Gestor.Controllers
{
    public class MedicoController : Controller
    {
        private readonly IMedicoService _medico;

        public MedicoController(IMedicoService pruebaLabService)
        {
            _medico = pruebaLabService;
        }
        public async Task<IActionResult> Index()
        {
            return View("Index", await _medico.GetAllViewModel());
        }

        public async Task<IActionResult> Add()
        {
            SaveMedicoViewModel vm = new SaveMedicoViewModel();
            return View("SaveMedicos", vm);
        }
        [HttpPost]
        public async Task<IActionResult> Add(SaveMedicoViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View("SaveMedicos", vm);
            }
            await _medico.Add(vm);
            return RedirectToRoute(new { controller = "Medico", action = "Index" });
        }

        public async Task<IActionResult> Edit(int id)
        {
            return View("SaveMedicos", await _medico.GetByIdSaveViewModel(id));
        }
        [HttpPost]
        public async Task<IActionResult> Edit(SaveMedicoViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View("SaveMedicos", vm);
            }

            await _medico.Update(vm);
            return RedirectToRoute(new { controller = "Medico", action = "Index" });
        }
        public async Task<IActionResult> Delete(int id)
        {
            return View("DeleteMedicos", await _medico.GetByIdSaveViewModel(id));
        }
        [HttpPost]
        public async Task<IActionResult> DeletePost(int Id)
        {
            await _medico.Delete(Id);
            return RedirectToRoute(new { controller = "Medico", action = "Index" });
        }
    }
}
