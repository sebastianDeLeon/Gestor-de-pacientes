using Gestor.Core.Application.Interfaces.Services;
using Gestor.Core.Application.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor.Core.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationLayer(this IServiceCollection services, IConfiguration configuration)
        {
            #region Services
            services.AddTransient<ICitasService, CitasCervice>();
            services.AddTransient<IEstadoCitaService, EstadoCitaService>();
            services.AddTransient<IMedicoService, MedicoService>();
            services.AddTransient<IPacientesService, PacienteService>();
            services.AddTransient<IPruebaLabService, PruebaLabService>();
            services.AddTransient<IResultadoLabService, ResultadoLabService>();
            services.AddTransient<IUsuarioService, UsuarioService>();
            #endregion
        }
    }
}
