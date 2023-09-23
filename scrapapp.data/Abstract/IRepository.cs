namespace scrapapp.data.Abstract
{
    public interface IRepository<T>
    {
        Task<T> GetById(int id);
        Task CreateAsync(T entity);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}