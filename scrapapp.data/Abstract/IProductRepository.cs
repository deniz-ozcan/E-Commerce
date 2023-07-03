using System.Collections.Generic;
using scrapapp.entity;

namespace scrapapp.data.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        Product GetProductDetails(string url);
        Product GetBySlugWithCategories(string slug);
        List<Product> GetProductsByCategory(string name, int page, int pageSize);
        List<Product> GetSearchResult(string searchString);
        int GetCountByCategory(string category);
        void Update(Product entity, int[] categoryIds);
    }
}