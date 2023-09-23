using scrapapp.entity;

namespace scrapapp.business.Abstract
{
    public interface IProductService : IValidator<Product>
    {
        Task<List<Product>> GetAllProductsAsync();
        Task<List<Product>> GetProductsByCategoryAsync(string name, int page, int pageSize);
        Task<int> GetProductsCountByCategoryAsync(string category);
        Task<Product> GetByIdAsync(int id);
        Task<Product> CreateAsync(Product entity);
        Task UpdateAsync(Product update, Product entity);
        Task DeleteAsync(Product entity);
    }
}