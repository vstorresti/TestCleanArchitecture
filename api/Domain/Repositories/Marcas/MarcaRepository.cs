using api.Domain.Entities;
using api.Infra.Database;

namespace api.Domain.Repositories.Marcas
{
    public class MarcaRepository : EntityFrameworkRepository<Marca>, IMarcaRepository
    {

        public MarcaRepository(EntityContext entityContext) : base(entityContext)
        {

        }



    }
}
