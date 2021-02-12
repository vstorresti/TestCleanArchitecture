using api.Domain.Entities;
using api.Infra.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.Domain.Repositories
{
    public class EntityFrameworkRepository<Entity> : IGenericRepository<Entity> where Entity : BaseModel
    {
        private readonly EntityContext _entityContext;
        private readonly DbSet<Entity> _entity;

        public EntityFrameworkRepository(EntityContext entityContext)
        {

            _entityContext = entityContext;
            _entity = _entityContext.Set<Entity>();
        }

        public virtual async Task<IEnumerable<Entity>> All()
        {
            return await _entity.ToListAsync();
        }

        public virtual Task<Entity> Delete(Entity entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task FindById(int id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<Entity> Save(Entity entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task Update(Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}
