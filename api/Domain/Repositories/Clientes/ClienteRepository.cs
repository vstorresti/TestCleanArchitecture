using api.Domain.Entities;
using api.Infra.Database;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.Domain.Repositories.Clientes
{
    public class ClienteRepository : EntityFrameworkRepository<Cliente>, IClienteRepository
    {
        private readonly EntityContext _entityContext;
        private readonly DbSet<Cliente> _clientes;
        public ClienteRepository(EntityContext entityContext) : base(entityContext)
        {
            _entityContext = entityContext;
            _clientes = entityContext.Set<Cliente>();
        }

        public async override Task<IEnumerable<Cliente>> All()
        {
            return await _clientes.Include(x => x.Endereco).ToListAsync();
        }
    }
}
