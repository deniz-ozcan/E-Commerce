using scrapapp.entity;

namespace scrapapp.business.Abstract
{
    public interface IProductService : IValidator<Product>
    {
        Task<Product> GetBySlug(string slug);
        Product GetBySlugWithCategories(string slug);
        Product GetProductDetails(string url);
        List<Product> GetProductsByCategory(string name, int page, int pageSize);
        int GetCountByCategory(string category);
        List<Product> GetSearchResult(string searchString);
        Task<List<Product>> GetAll();
        Task<List<Product>> GetAllProducts();
        bool Create(Product entity);
        Task<Product> CreateAsync(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
        Task DeleteAsync(Product entity);
        Task UpdateAsync(Product entityToUpdate, Product entity);
        bool Update(Product entity, int[] categoryIds);
    }
}