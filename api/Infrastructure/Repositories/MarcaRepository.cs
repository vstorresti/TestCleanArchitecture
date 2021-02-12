using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Interfaces;
using Infrastructure.Data;
using api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class MarcaRepository : EntityFrameworkRepository<Marca>, IMarcaRepository
    {
        private DataContext _context;
        private readonly DbSet<Marca> _marcas;

        public MarcaRepository(DataContext context): base(context)
        {
            _context = context;
            _marcas = context.Set<Marca>();
        }

    }
}
