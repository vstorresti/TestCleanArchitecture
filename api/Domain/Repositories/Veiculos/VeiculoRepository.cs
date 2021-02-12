using api.Domain.Entities;
using api.Infra.Database;

namespace api.Domain.Repositories.Veiculos
{
    public class VeiculoRepository : EntityFrameworkRepository<Veiculo>, IVeiculoRepository
    {

        public VeiculoRepository(EntityContext entityContext) : base(entityContext)
        {

        }



    }
}
