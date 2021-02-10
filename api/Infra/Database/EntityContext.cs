using Microsoft.EntityFrameworkCore;
using api.Domain.Entities;

namespace api.Infra.Database
{
    public class EntityContext : DbContext
    {
        public EntityContext(DbContextOptions<EntityContext> options) :
            base(options)
        {
        }

        public EntityContext()
        {
        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Operador> Operadores { get; set; }

        
    }
}
