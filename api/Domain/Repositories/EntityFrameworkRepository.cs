using api.Domain.Entities;
using api.Infra.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.Domain.Services
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

        public async Task<ICollection<Entity>> All()
        {
            return await _entity.ToListAsync();
        }

        public Task<Entity> Delete(Entity user)
        {
            throw new NotImplementedException();
        }

        public Task FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Entity> Save(Entity user)
        {
            throw new NotImplementedException();
        }

        public Task Update(Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}
