using System.Threading.Tasks;
using Application.Interfaces;
using Application.ViewModel;
using Domain.Interfaces;

namespace Application.Services
{
    public class VeiculoService : IVeiculoService
    {
        public IVeiculoRepository _veiculoRepository;

        public VeiculoService(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }

        public async Task<VeiculoViewModel> GetVeiculos()
        {
            var veiculos = new VeiculoViewModel()
            {
                Veiculos = await _veiculoRepository.GetAll()
            };

            return veiculos;
        }
    }
}