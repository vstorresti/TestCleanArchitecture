using api.Domain.Entities;
using api.Domain.Repositories;
using api.Infra.Database;

namespace api.Domain.Services
{
    public class ClienteRepository : EntityFrameworkRepository<Cliente>, IClienteRepository
    {

        public ClienteRepository(EntityContext entityContext) : base(entityContext)
        {

        }



    }
}
