using api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(new Cliente
            {
                Id = -1,
                Nome = "Cássio Morais",
                Cpf = "111.111.111-11",
                DiaDeNascimento = DateTime.Now,
                Senha = "senhateste@",
                TipoDeUsuario = EnumTipoDeUsuario.CLIENTE

            });


            base.OnModelCreating(modelBuilder);
        }



    }
}
