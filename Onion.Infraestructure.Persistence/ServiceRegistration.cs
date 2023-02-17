using Gestor.Core.Application.Interfaces.Repositories;
using Gestor.Infraestructure.Persistence.Contexts;
using Gestor.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Gestor.Infraestructure.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            #region Contexts
            if (configuration.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<AplicationContext>(option => option.UseInMemoryDatabase("ApplicationDb"));
            }
            else
            {
                services.AddDbContext<AplicationContext>(option =>
                option.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                m => m.MigrationsAssembly(typeof(AplicationContext).Assembly.FullName)));
            }
            #endregion

            #region Repositories
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IEstadoCitaRepository, EstadoCitaRepository>();
            services.AddTransient<ICitasRepository, CitasRepository>();
            services.AddTransient<IMedicoRepository, MedicoRepository>();
            services.AddTransient<IPacienteRepository, PacienteRepository>();
            services.AddTransient<IPruebaLabRepository, PruebaLabRepository>();
            services.AddTransient<IResultadoLabRepository, ResultRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            #endregion  
        }
    }
}