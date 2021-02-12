using api.Infra.Database;
using api.Domain.Entities;
using api.Domain.Repositories;

namespace api.Domain.Repositories.Operadores
{
    public class OperadorRepository : EntityFrameworkRepository<Operador>, IOperadorRepository
    {

        public OperadorRepository(EntityContext entityContext) : base(entityContext)
        {

        }



    }
}
