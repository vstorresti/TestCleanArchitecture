using System.Threading.Tasks;
using Application.Interfaces;
using Application.ViewModel;
using Domain.Interfaces;

namespace Application.Services
{
    public class LocacaoVeiculoService : ILocacaoVeiculoService
    {
        public ILocacaoVeiculoRepository _locacaoVeiculoRepository;

        public LocacaoVeiculoService(ILocacaoVeiculoRepository locacaoVeiculoRepository)
        {
            _locacaoVeiculoRepository = locacaoVeiculoRepository;
        }

        public async Task<LocacaoVeiculoViewModel> GetLocacaoVeiculos()
        {
            var locacaoVeiculos = new LocacaoVeiculoViewModel()
            {
                LocacaoVeiculos = await _locacaoVeiculoRepository.GetAll()
            };

            return locacaoVeiculos;
        }
    }
}