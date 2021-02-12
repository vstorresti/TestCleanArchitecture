using api.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.Domain.Services
{
    public interface IGenericService<T> where T : BaseModel
    {
        Task FindById(int id);

        Task Save(T t);

        Task Update(T t);

        Task<T> Delete(T t);

        Task<IEnumerable<T>> All();
    }
}
