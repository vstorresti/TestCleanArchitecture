using System.Threading.Tasks;
using api.Models.Entities;
using Application.Interfaces;
using Application.ViewModel.Clientes;
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
            var clientes =
                new ClienteViewModel()
                { Clientes = await _clienteRepository.GetAll() };

            return clientes;
        }

        public async Task<ClienteVm> GetById(int id)
        {
            var cliente =
                new ClienteVm()
                { Cliente = await _clienteRepository.GetById(id) };
            return cliente;
        }

        public async Task Save(Cliente cliente)
        {
            await _clienteRepository.Save(cliente);
        }

        public async Task Delete(Cliente cliente)
        {
            await _clienteRepository.Delete(cliente);
        }

        public async Task Update(Cliente cliente)
        {
            await _clienteRepository.Update(cliente);
        }
    }
}
