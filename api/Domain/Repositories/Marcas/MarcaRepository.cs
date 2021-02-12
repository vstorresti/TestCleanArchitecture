using api.Infra.Database;
using api.Domain.Entities;
using api.Domain.Repositories;

namespace api.Domain.Repositories.Marcas
{
    public class MarcaRepository : EntityFrameworkRepository<Marca>, IMarcaRepository
    {

        public MarcaRepository(EntityContext entityContext) : base(entityContext)
        {

        }



    }
}
