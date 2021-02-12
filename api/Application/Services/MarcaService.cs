using System.Threading.Tasks;
using Application.Interfaces;
using Application.ViewModel;
using Domain.Interfaces;

namespace Application.Services
{
    public class MarcaService : IMarcaService
    {
        public IMarcaRepository _marcaRepository;

        public MarcaService(IMarcaRepository marcaRepository)
        {
            _marcaRepository = marcaRepository;
        }

        public async Task<MarcaViewModel> GetMarcas()
        {
            var marcas = new MarcaViewModel()
            {
                Marcas = await _marcaRepository.GetAll()
            };

            return marcas;
        }
    }
}