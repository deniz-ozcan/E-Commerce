namespace scrapapp.data.Abstract
{
    public interface IRepository<T>
    {
        Task<T> GetById(int id);
        Task<T> GetBySlug(string slug);
        Task<List<T>> GetAll();
        void Create(T entity);
        Task CreateAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}