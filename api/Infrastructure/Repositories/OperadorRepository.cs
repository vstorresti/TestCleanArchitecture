using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Interfaces;
using Infrastructure.Data;
using api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class OperadorRepository : IOperadorRepository
    {
        private DataContext _context;

        public OperadorRepository(DataContext context)
        {
            _context = context;
        }

        public Task Delete(Operador id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Operador>> GetAll()
        {
            var operador = _context.Operadores;
            return await operador.ToListAsync();
        }

        public Task<Operador> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task Save(Operador t)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(Operador t)
        {
            throw new System.NotImplementedException();
        }
    }
}
