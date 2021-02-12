using api.Infra.Database;
using api.Domain.Entities;
using api.Domain.Repositories;

namespace api.Domain.Repositories.LocacaoVeiculos
{
    public class LocacaoVeiculoRepository : EntityFrameworkRepository<LocacaoVeiculo>, ILocacaoVeiculoRepository
    {

        public LocacaoVeiculoRepository(EntityContext entityContext) : base(entityContext)
        {

        }



    }
}
