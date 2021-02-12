using api.Infra.Database;
using api.Domain.Entities;
using api.Domain.Repositories;

namespace api.Domain.Repositories.Veiculos
{
    public class VeiculoRepository : EntityFrameworkRepository<Veiculo>, IVeiculoRepository
    {

        public VeiculoRepository(EntityContext entityContext) : base(entityContext)
        {

        }



    }
}
