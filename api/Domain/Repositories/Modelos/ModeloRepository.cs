using api.Domain.Entities;
using api.Infra.Database;

namespace api.Domain.Repositories.Modelos
{
    public class ModeloRepository : EntityFrameworkRepository<Modelo>, IModeloRepository
    {

        public ModeloRepository(EntityContext entityContext) : base(entityContext)
        {

        }



    }
}
