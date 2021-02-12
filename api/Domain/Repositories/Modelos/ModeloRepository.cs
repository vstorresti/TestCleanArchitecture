using api.Infra.Database;
using api.Domain.Entities;
using api.Domain.Repositories;

namespace api.Domain.Repositories.Modelos
{
    public class ModeloRepository : EntityFrameworkRepository<Modelo>, IModeloRepository
    {

        public ModeloRepository(EntityContext entityContext) : base(entityContext)
        {

        }



    }
}
