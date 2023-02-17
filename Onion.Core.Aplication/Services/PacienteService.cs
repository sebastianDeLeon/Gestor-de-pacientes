using Gestor.Core.Application.Interfaces.Repositories;
using Gestor.Core.Application.Interfaces.Services;
using Gestor.Core.Application.ViewModel.Paciente;
using Gestor.Core.Domain.Entities;

namespace Gestor.Core.Application.Services
{
    public class PacienteService : IPacientesService
    {
        private readonly IPacienteRepository _paciente;

        public PacienteService(IPacienteRepository pacienteRepository)
        {
            _paciente = pacienteRepository;
        }

        private Pacientes pacientes = new();
        private PacienteViewModel pVm = new();
        private SavePacienteViewModel savePacient = new();
        public async Task Add(SavePacienteViewModel vm)
        {
            pacientes.nombre = vm.nombre;
            pacientes.apellido = vm.apellido;
            pacientes.alergico = vm.alergico;
            pacientes.fumador = vm.fumador;
            pacientes.fecha_de_nacimiento = vm.fecha_de_nacimiento;
            pacientes.cedula = vm.cedula;
            pacientes.direccion = vm.direccion;
            pacientes.foto = vm.foto;
            pacientes.telefono = vm.telefono;

            await _paciente.AddAsync(pacientes);
        }

        public async Task Delete(int id)
        {
            var borrarP = await _paciente.GetByIdAsync(id);
            await _paciente.DeleteAsync(borrarP);
        }

        public async Task<List<PacienteViewModel>> GetAllViewModel()
        {
            var listaPas = await _paciente.GetAllAsync();

            return listaPas.Select(x => new PacienteViewModel
            {
                Id = x.Id,
                nombre = x.nombre,
                apellido = x.apellido,
                alergico = x.alergico,
                fumador = x.fumador,
                fecha_de_nacimiento = x.fecha_de_nacimiento,
                cedula = x.cedula,
                direccion = x.direccion,
                foto = x.foto,
                telefono = x.telefono,
            }).ToList();
        }

        public async Task<SavePacienteViewModel> GetByIdSaveViewModel(int id)
        {
            var pacienteId = await _paciente.GetByIdAsync(id);

            savePacient.nombre = pacienteId.nombre;
            savePacient.apellido = pacienteId.apellido;
            savePacient.alergico = pacienteId.alergico;
            savePacient.fumador = pacienteId.fumador;
            savePacient.fecha_de_nacimiento = pacienteId.fecha_de_nacimiento;
            savePacient.cedula = pacienteId.cedula;
            savePacient.direccion = pacienteId.direccion;
            savePacient.foto = pacienteId.foto;
            savePacient.telefono = pacienteId.telefono;
            return savePacient;
        }

        public async Task Update(SavePacienteViewModel vm)
        {
            pacientes.Id = vm.Id;
            pacientes.nombre = vm.nombre;
            pacientes.apellido = vm.apellido;
            pacientes.alergico = vm.alergico;
            pacientes.fumador = vm.fumador;
            pacientes.fecha_de_nacimiento = vm.fecha_de_nacimiento;
            pacientes.cedula = vm.cedula;
            pacientes.direccion = vm.direccion;
            pacientes.foto = vm.foto;
            pacientes.telefono = vm.telefono;

            await _paciente.UpdateAsync(pacientes);
        }
    }
}
