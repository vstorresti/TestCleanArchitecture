using api.Domain.Entities;
using api.Domain.Repositories.LocacaoVeiculos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.Domain.Services.LocacaoVeiculos
{
    public class LocacaoVeiculoService : ILocacaoVeiculoService
    {
        private readonly ILocacaoVeiculoRepository _locacaoVeiculoRepository;
        public LocacaoVeiculoService(ILocacaoVeiculoRepository locacaoVeiculoRepository)
        {
            _locacaoVeiculoRepository = locacaoVeiculoRepository;
        }


        public async Task Save(LocacaoVeiculo locacaoVeiculo)
        {
            await _locacaoVeiculoRepository.Save(locacaoVeiculo);
        }

        public async Task<IEnumerable<LocacaoVeiculo>> All()
        {
            return await _locacaoVeiculoRepository.All();
        }

        public Task FindById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(LocacaoVeiculo t)
        {
            throw new System.NotImplementedException();
        }

        public Task<LocacaoVeiculo> Delete(LocacaoVeiculo t)
        {
            throw new System.NotImplementedException();
        }
    }
}
