using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using scrapapp.data.Abstract;
using scrapapp.entity;

namespace scrapapp.data.Concrete.EfCore
{
    public class EfCoreProductRepository :
        EfCoreGenericRepository<Product>, IProductRepository
    {
        public EfCoreProductRepository(ShopContext context) : base(context)
        {

        }
        private ShopContext ShopContext
        {
            get { return context as ShopContext; }
        }
        public Product GetBySlugWithCategories(string slug)
        {
            return ShopContext.Products
                    .Where(i => i.Detail.Slug == slug)
                    .FirstOrDefault();
        }
        public int GetCountByCategory(string category)
        {
            return ShopContext.Products.Count();
        }
        public Product GetProductDetails(string url)
        {
            return ShopContext.Products
                    .Where(i => i.Detail.Slug == url)
                    .FirstOrDefault();

        }
        public List<Product> GetProductsByCategory(string name, int page, int pageSize)
        {
            return ShopContext.Products.Skip((page - 1) * pageSize).Take(pageSize).ToList();
        }
        public List<Product> GetSearchResult(string searchString)
        {
            var products = ShopContext.Products
                .Where(i =>  
                    i.Detail.Name.ToLower().Contains(searchString.ToLower()) || 
                    i.Detail.Model.ToLower().Contains(searchString.ToLower())
                ).AsQueryable();

            return products.ToList();
        }

        public void Update(Product entity, int[] categoryIds)
        {
            var product = ShopContext.Products
                    .FirstOrDefault(i => i.Id == entity.Id);
            if (product != null)
            {
                product.Detail.Name = entity.Detail.Name;
                product.Price = entity.Price;
                product.Detail.Image = entity.Detail.Image;
            }
        }
    }
}