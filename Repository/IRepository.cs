using BarberAPI.Context;
using Microsoft.AspNetCore.Mvc;

namespace BarberAPI.Repository
{
    public interface IRepository<T>
    {
        public Task <IEnumerable<T>> Get();
        public Task <ActionResult<T>> Get(int id);
        public Task<ActionResult<T>> Post(T entity);
        public Task<ActionResult<T>> Put(T entity,int id);
        public Task<ActionResult<T>> Delete(int id);

    }
}
