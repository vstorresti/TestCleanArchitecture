using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Interfaces;
using Infrastructure.Data;
using api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class LocacaoVeiculoRepository : ILocacaoVeiculoRepository
    {
        private DataContext _context;

        public LocacaoVeiculoRepository(DataContext context)
        {
            _context = context;
        }

        public Task Delete(LocacaoVeiculo lv)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<LocacaoVeiculo>> GetAll()
        {
            var locacaoVeiculo = _context.LocacaoVeiculos;
            return await locacaoVeiculo.ToListAsync();
        }

        public Task<LocacaoVeiculo> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task Save(LocacaoVeiculo t)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(LocacaoVeiculo t)
        {
            throw new System.NotImplementedException();
        }
    }
}
