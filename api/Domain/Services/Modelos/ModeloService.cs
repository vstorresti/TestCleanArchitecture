using api.Domain.Entities;
using api.Domain.Repositories.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.Domain.Services.Modelos
{
    public class ModeloService : IModeloService
    {
        private readonly IModeloRepository _modeloRepository;
        public ModeloService(IModeloRepository modeloRepository)
        {
            _modeloRepository = modeloRepository;
        }


        public async Task Save(Modelo modelo)
        {
            await _modeloRepository.Save(modelo);
        }

        public async Task<IEnumerable<Modelo>> All()
        {
            return await _modeloRepository.All();
        }

        public Task FindById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(Modelo t)
        {
            throw new System.NotImplementedException();
        }

        public Task<Modelo> Delete(Modelo t)
        {
            throw new System.NotImplementedException();
        }
    }
}
