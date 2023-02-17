using Gestor.Core.Application.Interfaces.Repositories;
using Gestor.Core.Application.Interfaces.Services;
using Gestor.Core.Application.ViewModel.Citas;
using Gestor.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor.Core.Application.Services
{
    public class CitasCervice : ICitasService
    {
        public readonly ICitasRepository _citas;

        public readonly IMedicoRepository _medico;
        public readonly IPacienteRepository _paciente;

        public CitasCervice(ICitasRepository citas,
            IPacienteRepository pacientes, IMedicoRepository medico)
        {
            _citas = citas;
            _medico = medico;
            _paciente = pacientes;
        }
        Citas cita = new();
        SaveCitasViewModel citasSave = new();
        public async Task Add(SaveCitasViewModel vm)
        {
            cita.motivo = vm.motivo;
            cita.Fecha_hora = vm.Fecha_hora;
            cita.medicoId = vm.medicoId;
            cita.pacienteId = vm.pacienteId;
            cita.citaCompletada = vm.citaCompletada;
            cita.estadoResultado = vm.estadoResultado;

            await _citas.AddAsync(cita);
        }

        public async Task Delete(int id)
        {
            var c = await _citas.GetByIdAsync(id);
            await _citas.DeleteAsync(c);
        }

        public async Task<List<CitasViewModel>> GetAllViewModel()
        {
            var c = await _citas.GetAllAsync();
            List<CitasViewModel> citasViewModel = new List<CitasViewModel>();
            CitasViewModel viewModel = new CitasViewModel();
            foreach (Citas vm in c)
            {
                viewModel.Id = vm.Id;
                viewModel.Fecha_hora = vm.Fecha_hora;
                viewModel.medicoId = vm.medicoId;
                viewModel.pacienteId = vm.pacienteId;
                viewModel.estadoResultado = vm.estadoResultado;
                viewModel.citaCompletada = vm.citaCompletada;
                viewModel.motivo = vm.motivo;
                viewModel.medico = await _medico.GetByIdAsync(vm.medicoId);
                viewModel.paciente = await _paciente.GetByIdAsync(vm.pacienteId);
                citasViewModel.Add(viewModel);
            }

            return citasViewModel;
        }

        public async Task<SaveCitasViewModel> GetByIdSaveViewModel(int id)
        {
            var citaId = await _citas.GetByIdAsync(id);

            citasSave.Id = citaId.Id;
            citasSave.motivo = citaId.motivo;
            citasSave.Fecha_hora = citaId.Fecha_hora;
            citasSave.medicoId = citaId.medicoId;
            citasSave.pacienteId = citaId.pacienteId;
            cita.citaCompletada = citaId.citaCompletada;
            cita.estadoResultado = citaId.estadoResultado;

            return citasSave;
        }

        public async Task Update(SaveCitasViewModel vm)
        {
            cita.Id = vm.Id;
            cita.motivo = vm.motivo;
            cita.Fecha_hora = vm.Fecha_hora;
            cita.medicoId = vm.medicoId;
            cita.pacienteId = vm.pacienteId;
            cita.citaCompletada = vm.citaCompletada;
            cita.estadoResultado = vm.estadoResultado;

            await _citas.UpdateAsync(cita);
        }
    }
}
