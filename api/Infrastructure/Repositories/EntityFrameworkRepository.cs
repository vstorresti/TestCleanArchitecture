using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using api.Models.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class EntityFrameworkRepository<Entity> : IGenericRepository<Entity> where Entity : BaseModel
    {
        private readonly DataContext _entityContext;
        private readonly DbSet<Entity> _entity;

        public EntityFrameworkRepository(DataContext entityContext)
        {

            _entityContext = entityContext;
            _entity = _entityContext.Set<Entity>();
        }

        public virtual async Task<IEnumerable<Entity>> GetAll()
        {
            return await _entity.ToListAsync();
        }

        public virtual Task Delete(Entity entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task<Entity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public virtual Task Save(Entity entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task Update(Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}