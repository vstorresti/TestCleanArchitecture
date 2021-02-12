using api.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.Domain.Repositories
{
    public interface IGenericRepository<Entity> where Entity : BaseModel
    {
        Task FindById(int id);

        Task Update(Entity entity);

        Task<Entity> Save(Entity entity);

        Task<Entity> Delete(Entity entity);

        Task<IEnumerable<Entity>> All();
    }
}
