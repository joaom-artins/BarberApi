using BarberAPI.Context;

namespace BarberAPI.Repository
{
    public interface IRepository<T>
    {
        public T Get();
        public T Get(int id);
        public T Post(T entity);
        public T Put(T entity,int id);
        public T Delete(int id);

    }
}
