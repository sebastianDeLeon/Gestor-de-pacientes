using Gestor.Core.Application.Interfaces.Services;
using Gestor.Core.Application.ViewModel.Usuario;
using Microsoft.AspNetCore.Mvc;

namespace Gestor.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _usuario;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuario = usuarioService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _usuario.GetAllViewModel());
        }

        public async Task<IActionResult> Add()
        {
            ViewBag.UsuarioRep = "";
            SaveUsuarioViewModel vm = new SaveUsuarioViewModel();
            return View("SaveUsuarios", vm);
        }
        [HttpPost]
        public async Task<IActionResult> Add(SaveUsuarioViewModel vm,string password2)
        {
            if (!ModelState.IsValid || (vm.password != password2))
            {
                return View("SaveUsuarios", vm);
            }

            List<UsuarioViewModel> usernames = await _usuario.GetAllViewModel();
            foreach (UsuarioViewModel usuario in usernames)
            {
                if (usuario.Nombre_de_usuario == vm.Nombre_de_usuario)
                {
                    ViewBag.UsuarioRep = "El nombre de usuario ya existe";
                    return View("SaveUsuarios", vm);
                }
            }
            await _usuario.Add(vm);
            return RedirectToRoute(new { controller = "Usuario", action = "Index" });
        }

        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.UsuarioRep = "";
            return View("SaveUsuarios", await _usuario.GetByIdSaveViewModel(id));
        }
        [HttpPost]
        public async Task<IActionResult> Edit(SaveUsuarioViewModel vm)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View("SaveUsuarios", vm);
                }
                //List<UsuarioViewModel> usernames = await _usuario.GetAllViewModel();
                //foreach (UsuarioViewModel usuario in usernames)
                //{
                //    if (usuario.Nombre_de_usuario == vm.Nombre_de_usuario)
                //    {
                //        ViewBag.UsuarioRep = "El nombre de usuario ya existe";
                //        return View("SaveUsuarios", vm);
                //    }
                //}
                await _usuario.Update(vm);
                return RedirectToRoute(new { controller = "Usuario", action = "Index" });
            }
            catch 
            {
                return View("SaveUsuarios", vm);
            }
            
        }
        public async Task<IActionResult> Delete(int id)
        {
            return View("DeleteUsuarios", await _usuario.GetByIdSaveViewModel(id));
        }
        [HttpPost]
        public async Task<IActionResult> DeletePost(int Id)
        {

            await _usuario.Delete(Id);
            return RedirectToRoute(new { controller = "Usuario", action = "Index" });
        }
    }
}
