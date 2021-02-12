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
        public DbSet<CheckList> CheckLists { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<LocacaoVeiculo> LocacaoVeiculos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Endereco>().HasData(new Endereco
            {
                Id = -1,
                Cep = "00000-000",
                Estado = "MG",
                Cidade = "Belo Horizonte",
                Logradouro = "Rua Fulano de tal, Bairro Beltrano",
                Numero = 31
            });


            modelBuilder.Entity<Cliente>().HasData(new Cliente
            {
                Id = -1,
                Nome = "Cássio Morais",
                Cpf = "111.111.111-11",
                DiaDeNascimento = DateTime.Now,
                Senha = "senhateste@",
                TipoDeUsuario = EnumTipoDeUsuario.CLIENTE,
                EndereçoId = -1
            });


            base.OnModelCreating(modelBuilder);
        }



    }
}
