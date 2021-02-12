using api.Infra.Database;
using api.Domain.Entities;
using api.Domain.Repositories;

namespace api.Domain.Repositories.Clientes
{
    public class ClienteRepository : EntityFrameworkRepository<Cliente>, IClienteRepository
    {

        public ClienteRepository(EntityContext entityContext) : base(entityContext)
        {

        }



    }
}
