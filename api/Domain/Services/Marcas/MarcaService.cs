using api.Domain.Entities;
using api.Domain.Repositories.Marcas;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.Domain.Services.Marcas
{
    public class MarcaService : IMarcaService
    {
        private readonly IMarcaRepository _marcaRepository;
        public MarcaService(IMarcaRepository marcaRepository)
        {
            _marcaRepository = marcaRepository;
        }


        public async Task Save(Marca marca)
        {
            await _marcaRepository.Save(marca);
        }

        public async Task<IEnumerable<Marca>> All()
        {
            return await _marcaRepository.All();
        }

        public Task FindById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(Marca t)
        {
            throw new System.NotImplementedException();
        }

        public Task<Marca> Delete(Marca t)
        {
            throw new System.NotImplementedException();
        }
    }
}
