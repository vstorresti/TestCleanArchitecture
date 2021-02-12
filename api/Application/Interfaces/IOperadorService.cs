using System.Threading.Tasks;
using Application.ViewModel;

namespace Application.Interfaces
{
    public interface IOperadorService
    {
        Task<OperadorViewModel> GetOperadores();
    }
}