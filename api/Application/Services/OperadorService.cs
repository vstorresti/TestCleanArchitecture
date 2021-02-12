using System.Threading.Tasks;
using Application.Interfaces;
using Application.ViewModel;
using Domain.Interfaces;

namespace Application.Services
{
    public class OperadorService : IOperadorService
    {
        public IOperadorRepository _operadorRepository;

        public OperadorService(IOperadorRepository operadorRepository)
        {
            _operadorRepository = operadorRepository;
        }

        public async Task<OperadorViewModel> GetOperadores()
        {
            var operadores = new OperadorViewModel()
            {
                Operadores = await _operadorRepository.GetAll()
            };

            return operadores;
        }
    }
}