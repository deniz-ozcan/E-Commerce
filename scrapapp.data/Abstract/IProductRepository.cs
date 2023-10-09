using scrapapp.entity;

namespace scrapapp.data.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product> GetByIdAsync(int id);
        Task<List<Product>> GetProducts(string q, int page, int pageSize);
        Task<int> GetProductsCount(string q);
        Task<List<Product>> GetAllProductsAsync();
    }
}