using System.Threading.Tasks;
using Application.Interfaces;
using Application.ViewModel;
using Domain.Interfaces;

namespace Application.Services
{
    public class ClienteService : IClienteService
    {
        public IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<ClienteViewModel> GetClientes()
        {
            var clientes = new ClienteViewModel()
            {
                Clientes = await _clienteRepository.GetAll()
            };

            return clientes;
        }
    }
}