using Gestor.Core.Application.Interfaces.Repositories;
using Gestor.Core.Application.Interfaces.Services;
using Gestor.Core.Application.ViewModel.Usuario;
using Gestor.Core.Domain.Entities;

namespace Gestor.Core.Application.Services
{
    public class UsuarioService : IUsuarioService
    {

        private readonly IUsuarioRepository _usuario;

        public UsuarioService(IUsuarioRepository usuario)
        {
            _usuario = usuario;
        }
        public async Task Add(SaveUsuarioViewModel vm)
        {
            Usuario usuario = new();
            usuario.Id = vm.Id;
            usuario.nombre = vm.nombre;
            usuario.apellido = vm.apellido;
            usuario.correo = vm.correo;
            usuario.Nombre_de_usuario = vm.Nombre_de_usuario;
            usuario.password = vm.password;
            usuario.Admin = vm.Admin;

            await _usuario.AddAsync(usuario);
        }

        public async Task Delete(int id)
        {
            var usuario = await _usuario.GetByIdAsync(id);
            await _usuario.DeleteAsync(usuario);
        }

        public async Task<List<UsuarioViewModel>> GetAllViewModel()
        {
            var usuarios = await _usuario.GetAllAsync();

            return usuarios.Select(u => new UsuarioViewModel
            {
                Id = u.Id,
                nombre = u.nombre,
                apellido = u.apellido,
                correo = u.correo,
                Nombre_de_usuario = u.Nombre_de_usuario,
                Admin = u.Admin
            }).ToList();


        }

        public async Task<SaveUsuarioViewModel> GetByIdSaveViewModel(int id)
        {
            var vm = await _usuario.GetByIdAsync(id);
            SaveUsuarioViewModel usuario = new();
            usuario.Id = vm.Id;
            usuario.nombre = vm.nombre;
            usuario.apellido = vm.apellido;
            usuario.correo = vm.correo;
            usuario.Nombre_de_usuario = vm.Nombre_de_usuario;
            usuario.password = vm.password;
            usuario.Admin = vm.Admin;
            return usuario;
        }

        public async Task Update(SaveUsuarioViewModel vm)
        {
            Usuario usuario = new();
            usuario.Id = vm.Id;
            usuario.nombre = vm.nombre;
            usuario.apellido = vm.apellido;
            usuario.correo = vm.correo;
            usuario.Nombre_de_usuario = vm.Nombre_de_usuario;
            usuario.password = vm.password;
            usuario.Admin = vm.Admin;

            await _usuario.UpdateAsync(usuario);
        }
    }
}

