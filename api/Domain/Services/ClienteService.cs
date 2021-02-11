using api.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.Domain.Services
{
    public class ClienteService
    {
        private readonly ClienteRepository _clienteRepository;
        public ClienteService(ClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }


        public async Task Save(Cliente cliente)
        {
            await _clienteRepository.Save(cliente);
        }

        public async Task<ICollection<Cliente>> All()
        {
            return await _clienteRepository.All();
        }

    }
}
