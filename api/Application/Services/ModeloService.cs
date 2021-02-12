using System.Threading.Tasks;
using Application.Interfaces;
using Application.ViewModel;
using Domain.Interfaces;

namespace Application.Services
{
    public class ModeloService : IModeloService
    {
        public IModeloRepository _modeloRepository;

        public ModeloService(IModeloRepository modeloRepository)
        {
            _modeloRepository = modeloRepository;
        }

        public async Task<ModeloViewModel> GetModelos()
        {
            var modelos = new ModeloViewModel()
            {
                Modelos = await _modeloRepository.GetAll()
            };

            return modelos;
        }
    }
}