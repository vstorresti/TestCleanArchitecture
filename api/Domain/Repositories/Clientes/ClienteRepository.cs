using api.Domain.Entities;
using api.Infra.Database;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.Domain.Repositories.Clientes
{
    public class ClienteRepository : EntityFrameworkRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(EntityContext entityContext) : base(entityContext)
        {
        }
    }
}
