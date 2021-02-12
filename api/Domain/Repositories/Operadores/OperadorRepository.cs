using api.Domain.Entities;
using api.Infra.Database;

namespace api.Domain.Repositories.Operadores
{
    public class OperadorRepository : EntityFrameworkRepository<Operador>, IOperadorRepository
    {

        public OperadorRepository(EntityContext entityContext) : base(entityContext)
        {

        }



    }
}
