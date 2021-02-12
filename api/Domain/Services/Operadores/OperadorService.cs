using api.Domain.Entities;
using api.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using api.Domain.Repositories.Operadores;

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

    }
}
