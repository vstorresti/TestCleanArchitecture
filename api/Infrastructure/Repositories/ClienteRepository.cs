using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Interfaces;
using Infrastructure.Data;
using api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private DataContext _context;

        public ClienteRepository(DataContext context)
        {
            _context = context;
        }

        public Task<Cliente> Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Cliente>> GetAll()
        {
            var cliente = _context.Clientes;
            return await cliente.ToListAsync();
        }

        public Task<Cliente> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task Save(Cliente t)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(Cliente t)
        {
            throw new System.NotImplementedException();
        }
    }
}
