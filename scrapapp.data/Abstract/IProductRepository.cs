using scrapapp.entity;

namespace scrapapp.data.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product> GetByIdAsync(int id);
        Task<List<Product>> GetProductsByCategoryAsync(string name, int page, int pageSize);
        Task<int> GetProductsCountByCategoryAsync(string category);
        Task<List<Product>> GetAllProductsAsync();
    }
}