using api.Domain.Entities;
using api.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using api.Domain.Repositories.Clientes;

namespace api.Domain.Services.Clientes
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }


        public async Task Save(Cliente cliente)
        {
            await _clienteRepository.Save(cliente);
        }

        public async Task<IEnumerable<Cliente>> All()
        {
            return await _clienteRepository.All();
        }

        public Task FindById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(Cliente t)
        {
            throw new System.NotImplementedException();
        }

        public Task<Cliente> Delete(Cliente t)
        {
            throw new System.NotImplementedException();
        }
    }
}
