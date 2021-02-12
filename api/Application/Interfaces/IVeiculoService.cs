using System.Threading.Tasks;
using Application.ViewModel;

namespace Application.Interfaces
{
    public interface IVeiculoService
    {
        Task<VeiculoViewModel> GetVeiculos();
    }
}