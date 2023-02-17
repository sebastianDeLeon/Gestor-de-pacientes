using Microsoft.AspNetCore.Mvc;
using Gestor.Core.Application.Interfaces.Services;
using Gestor.Core.Application.ViewModel.PruebasLaboratorio;

namespace Gestor.Controllers
{
    public class Pruebas : Controller
    {
        private readonly IPruebaLabService _prueba;

        public Pruebas (IPruebaLabService pruebaLabService)
        {
            _prueba = pruebaLabService;
        }
        public async Task<IActionResult> PruebasIndex()
        {
            return View("PruebasIndex",await _prueba.GetAllViewModel());
        }

        public async Task<IActionResult> Add()
        {
            SavePruebasLabViewModel vm = new SavePruebasLabViewModel();
            return View("SavePruebas",vm);
        }
        [HttpPost]
        public async Task<IActionResult> Add(SavePruebasLabViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View("SavePruebas", vm);
            }
            await _prueba.Add(vm);
            return RedirectToRoute(new { controller = "Pruebas", action = "PruebasIndex" });
        }

        public async Task<IActionResult> Edit(int id)
        {            
            return View("SavePruebas", await _prueba.GetByIdSaveViewModel(id));
        }
        [HttpPost]
        public async Task<IActionResult> Edit(SavePruebasLabViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View("SavePruebas", vm);
            }

            await _prueba.Update(vm);
            return RedirectToRoute(new { controller = "Pruebas", action = "PruebasIndex" });
        }
        public async Task<IActionResult> Delete(int id)
        {
            return View("DeletePruebas", await _prueba.GetByIdSaveViewModel(id));
        }
        [HttpPost]
        public async Task<IActionResult> DeletePost(int Id)
        {

            await _prueba.Delete(Id);
            return RedirectToRoute(new { controller = "Pruebas", action = "PruebasIndex" });
        }
    }
}
