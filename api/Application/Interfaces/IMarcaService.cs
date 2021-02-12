using System.Threading.Tasks;
using Application.ViewModel;

namespace Application.Interfaces
{
    public interface IMarcaService
    {
        Task<MarcaViewModel> GetMarcas();
    }
}