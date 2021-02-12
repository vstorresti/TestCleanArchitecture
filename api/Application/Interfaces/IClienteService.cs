using System.Threading.Tasks;
using Application.ViewModel;

namespace Application.Interfaces
{
    public interface IClienteService
    {
        Task<ClienteViewModel> GetClientes();
    }
}