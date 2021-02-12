using Application.Interfaces;
using Application.Services;
using Domain.Interfaces;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace api.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Infrastructure Layer
            services.AddScoped<IClienteService, ClienteService>();
            //Application Layer
            services.AddScoped<IClienteRepository, ClienteRepository>();
            
        }
    }
}