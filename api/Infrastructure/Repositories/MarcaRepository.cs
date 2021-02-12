using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Interfaces;
using Infrastructure.Data;
using api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class MarcaRepository : IMarcaRepository
    {
        private DataContext _context;

        public MarcaRepository(DataContext context)
        {
            _context = context;
        }

        public Task Delete(Marca t)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Marca>> GetAll()
        {
            var marca = _context.Marcas;
            return await marca.ToListAsync();
        }

        public Task<Marca> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task Save(Marca t)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(Marca t)
        {
            throw new System.NotImplementedException();
        }
    }
}
