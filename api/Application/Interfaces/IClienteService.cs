using System.Threading.Tasks;
using api.Models.Entities;
using Application.ViewModel.Clientes;

namespace Application.Interfaces
{
    public interface IClienteService
    {
        Task<ClienteViewModel> GetClientes();

        Task<ClienteVm> GetById(int id);

        Task Save(Cliente cliente);

        Task Delete(Cliente cliente);

        Task Update(Cliente cliente);
    }
}