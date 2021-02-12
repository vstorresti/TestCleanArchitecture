using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Interfaces;
using Infrastructure.Data;
using api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class ModeloRepository : IModeloRepository
    {
        private DataContext _context;

        public ModeloRepository(DataContext context)
        {
            _context = context;
        }

        public Task Delete(Modelo t)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Modelo>> GetAll()
        {
            var modelo = _context.Modelos;
            return await modelo.ToListAsync();
        }

        public Task<Modelo> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task Save(Modelo t)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(Modelo t)
        {
            throw new System.NotImplementedException();
        }
    }
}
