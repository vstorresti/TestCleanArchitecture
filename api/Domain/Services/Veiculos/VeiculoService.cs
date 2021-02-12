using api.Domain.Entities;
using api.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using api.Domain.Repositories.Veiculos;

namespace api.Domain.Services.Veiculos
{
    public class VeiculoService : IVeiculoService
    {
        private readonly IVeiculoRepository _veiculoRepository;
        public VeiculoService(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }


        public async Task Save(Veiculo veiculo)
        {
            await _veiculoRepository.Save(veiculo);
        }

        public async Task<IEnumerable<Veiculo>> All()
        {
            return await _veiculoRepository.All();
        }

        public Task FindById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(Veiculo t)
        {
            throw new System.NotImplementedException();
        }

        public Task<Veiculo> Delete(Veiculo t)
        {
            throw new System.NotImplementedException();
        }
    }
}
