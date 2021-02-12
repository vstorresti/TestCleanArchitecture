using api.Domain.Repositories.Clientes;
using api.Domain.Repositories.LocacaoVeiculos;
using api.Domain.Repositories.Marcas;
using api.Domain.Repositories.Modelos;
using api.Domain.Repositories.Operadores;
using api.Domain.Repositories.Veiculos;
using api.Domain.Services.Clientes;
using api.Domain.Services.LocacaoVeiculos;
using api.Domain.Services.Marcas;
using api.Domain.Services.Modelos;
using api.Domain.Services.Operadores;
using api.Domain.Services.Veiculos;
using Microsoft.Extensions.DependencyInjection;

namespace api.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Infrastructure Layer
            services.AddScoped<IOperadorRepository, OperadorRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<ILocacaoVeiculoRepository, LocacaoVeiculoRepository>();
            services.AddScoped<IMarcaRepository, MarcaRepository>();
            services.AddScoped<IModeloRepository, ModeloRepository>();
            services.AddScoped<IVeiculoRepository, VeiculoRepository>();


            //Application Layer
            services.AddScoped<IOperadorService, OperadorService>();
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<ILocacaoVeiculoService, LocacaoVeiculoService>();
            services.AddScoped<IMarcaService, MarcaService>();
            services.AddScoped<IModeloService, ModeloService>();
            services.AddScoped<IVeiculoService, VeiculoService>();
        }
    }
}