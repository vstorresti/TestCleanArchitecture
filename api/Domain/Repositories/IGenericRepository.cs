using api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.Domain.Services
{
    public interface IGenericRepository<Entity> where Entity : BaseModel
    {
        Task FindById(Guid id);

        Task Update(Entity entity);

        Task<Entity> Save(Entity user);

        Task<Entity> Delete(Entity user);

        Task<ICollection<Entity>> All();
    }
}
