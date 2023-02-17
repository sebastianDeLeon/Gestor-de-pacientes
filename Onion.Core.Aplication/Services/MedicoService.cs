using Gestor.Core.Application.Interfaces.Repositories;
using Gestor.Core.Application.Interfaces.Services;
using Gestor.Core.Application.ViewModel.Medico;
using Gestor.Core.Domain.Entities;

namespace Gestor.Core.Application.Services
{
    public class MedicoService : IMedicoService
    {
        private readonly IMedicoRepository _medico;

        public MedicoService(IMedicoRepository medicoService)
        {
            _medico = medicoService;
        }

        Medico medico = new Medico();
        SaveMedicoViewModel medicoSVM = new();

        public async Task Add(SaveMedicoViewModel vm)
        {
            medico.Id = vm.Id;
            medico.nombre = vm.nombre;
            medico.apellido = vm.apellido;
            medico.correo = vm.correo;
            medico.cedula = vm.cedula;
            medico.telefono = vm.telefono;
            medico.foto = vm.foto;

            await _medico.AddAsync(medico);
        }

        public async Task Delete(int id)
        {
            var medic = await _medico.GetByIdAsync(id);
            await _medico.DeleteAsync(medic);
        }

        public async Task<List<MedicoViewModel>> GetAllViewModel()
        {
            var usuarios = await _medico.GetAllAsync();

            return usuarios.Select(u => new MedicoViewModel
            {
                Id = u.Id,
                nombre = u.nombre,
                apellido = u.apellido,
                correo = u.correo,
                cedula = u.cedula,
                telefono = u.telefono,
                foto = u.foto
            }).ToList();
        }

        public async Task<SaveMedicoViewModel> GetByIdSaveViewModel(int id)
        {
            var medicoId = await _medico.GetByIdAsync(id);

            medicoSVM.Id = medicoId.Id;
            medicoSVM.nombre = medicoId.nombre;
            medicoSVM.apellido = medicoId.apellido;
            medicoSVM.correo = medicoId.correo;
            medicoSVM.cedula = medicoId.cedula;
            medicoSVM.telefono = medicoId.telefono;
            medicoSVM.foto = medicoId.foto;

            return medicoSVM;
        }

        public async Task Update(SaveMedicoViewModel vm)
        {
            medico.Id = vm.Id;
            medico.nombre = vm.nombre;
            medico.apellido = vm.apellido;
            medico.correo = vm.correo;
            medico.cedula = vm.cedula;
            medico.telefono = vm.telefono;
            medico.foto = vm.foto;

            await _medico.UpdateAsync(medico);
        }
    }
}
