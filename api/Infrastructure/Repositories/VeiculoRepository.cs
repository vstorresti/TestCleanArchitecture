using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Interfaces;
using Infrastructure.Data;
using api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class VeiculoRepository : IVeiculoRepository
    {
        private DataContext _context;

        public VeiculoRepository(DataContext context)
        {
            _context = context;
        }

        public Task Delete(Veiculo id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Veiculo>> GetAll()
        {
            var veiculo = _context.Veiculos;
            return await veiculo.ToListAsync();
        }

        public Task<Veiculo> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task Save(Veiculo t)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(Veiculo t)
        {
            throw new System.NotImplementedException();
        }
    }
}
