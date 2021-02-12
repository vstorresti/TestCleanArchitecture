using api.Domain.Entities;
using api.Infra.Database;

namespace api.Domain.Repositories.LocacaoVeiculos
{
    public class LocacaoVeiculoRepository : EntityFrameworkRepository<LocacaoVeiculo>, ILocacaoVeiculoRepository
    {

        public LocacaoVeiculoRepository(EntityContext entityContext) : base(entityContext)
        {

        }



    }
}
