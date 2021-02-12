using Microsoft.Extensions.DependencyInjection;
using api.Domain.Repositories.Clientes;
using api.Domain.Repositories.Operadores;
using api.Domain.Services.Clientes;
using api.Domain.Services.Operadores;

namespace api.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Application Layer
            services.AddScoped<IOperadorRepository, OperadorRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();

            //Infrastructure Layer
            services.AddScoped<IOperadorService, OperadorService>();
            services.AddScoped<IClienteService, ClienteService>();
        }
    }
}