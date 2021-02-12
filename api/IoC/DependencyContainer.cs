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
            // Application Layer
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IOperadorService, OperadorService>();
            services.AddScoped<IMarcaService, MarcaService>();
            services.AddScoped<IModeloService, ModeloService>();
            services.AddScoped<IVeiculoService, VeiculoService>();
            services.AddScoped<ILocacaoVeiculoService, LocacaoVeiculoService>();
            //Infrastructure Layer
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IOperadorRepository, OperadorRepository>();
            services.AddScoped<IMarcaRepository, MarcaRepository>();
            services.AddScoped<IModeloRepository, ModeloRepository>();
            services.AddScoped<IVeiculoRepository, VeiculoRepository>();
            services.AddScoped<ILocacaoVeiculoRepository, LocacaoVeiculoRepository>();
            
        }
    }
}