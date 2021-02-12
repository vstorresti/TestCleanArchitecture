using api.Domain.Entities;
using api.Domain.Repositories.Operadores;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.Domain.Services.Operadores
{
    public class OperadorService : IOperadorService
    {
        private readonly IOperadorRepository _operadorRepository;
        public OperadorService(IOperadorRepository operadorRepository)
        {
            _operadorRepository = operadorRepository;
        }


        public async Task Save(Operador operador)
        {
            await _operadorRepository.Save(operador);
        }

        public async Task<IEnumerable<Operador>> All()
        {
            return await _operadorRepository.All();
        }

        public Task FindById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(Operador t)
        {
            throw new System.NotImplementedException();
        }

        public Task<Operador> Delete(Operador t)
        {
            throw new System.NotImplementedException();
        }
    }
}
