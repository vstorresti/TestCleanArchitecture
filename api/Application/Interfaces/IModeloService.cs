using System.Threading.Tasks;
using Application.ViewModel;

namespace Application.Interfaces
{
    public interface IModeloService
    {
        Task<ModeloViewModel> GetModelos();
    }
}