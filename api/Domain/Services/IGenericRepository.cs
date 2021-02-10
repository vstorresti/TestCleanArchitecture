using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.Domain.Services
{
    public interface IGenericRepository
    {
        Task<TEntity> FindById<TEntity>(Guid id);

        Task<TEntity> Update<TEntity>(TEntity entity);

        Task<TEntity> Save<TEntity>(TEntity user);

        Task<TEntity> Delete<TEntity>(TEntity user);

        Task<ICollection<TEntity>> All<TEntity>();
    }
}
