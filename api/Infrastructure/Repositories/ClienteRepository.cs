using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Interfaces;
using Infrastructure.Data;
using api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class ClienteRepository : EntityFrameworkRepository<Cliente>, IClienteRepository
    {
        private DataContext _context;
        private readonly DbSet<Cliente> _clientes;

        public ClienteRepository(DataContext context): base(context)
        {
            _context = context;
            _clientes = context.Set<Cliente>();
        }

        public override async Task<IEnumerable<Cliente>> GetAll()
        {
            return await _clientes.Include( x => x.Endereco).ToListAsync();
        }

    }
}
