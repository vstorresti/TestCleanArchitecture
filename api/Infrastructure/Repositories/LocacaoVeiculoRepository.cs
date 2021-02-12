using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Interfaces;
using Infrastructure.Data;
using api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class LocacaoVeiculoRepository : EntityFrameworkRepository<LocacaoVeiculo>, ILocacaoVeiculoRepository
    {
        private DataContext _context;
        private readonly DbSet<LocacaoVeiculo> _locacaoVeiculo;

        public LocacaoVeiculoRepository(DataContext context): base(context)
        {
            _context = context;
            _locacaoVeiculo = context.Set<LocacaoVeiculo>();
        }

    }
}
