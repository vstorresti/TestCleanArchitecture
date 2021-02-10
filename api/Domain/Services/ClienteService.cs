using System.Collections.Generic;
using System.Threading.Tasks;
using api.Domain.Entities;

namespace api.Domain.Services
{
    public class ClienteService
    {
        public ClienteService(IGenericRepository repository)
        {
            _repository = repository;
        }

        private IGenericRepository _repository;

        public async Task Save(Cliente cliente)
        {
            // TO DO
            await _repository.Save(cliente);
        }

        public async Task<ICollection<Cliente>> All()
        {
            return await _repository.All<Cliente>();
        }
        
    }
}
