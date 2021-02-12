using System.Threading.Tasks;
using Application.ViewModel;

namespace Application.Interfaces
{
    public interface ILocacaoVeiculoService
    {
        Task<LocacaoVeiculoViewModel> GetLocacaoVeiculos();
    }
}