using Microsoft.EntityFrameworkCore;
using scrapapp.data.Abstract;
using scrapapp.entity;

namespace scrapapp.data.Concrete.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product>, IProductRepository
    {
        public EfCoreProductRepository(ShopContext context) : base(context) { }
        private ShopContext ShopContext
        {
            get { return context as ShopContext; }
        }
        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await ShopContext.Products
                    .ToListAsync();
        }
        public async Task<Product> GetByIdAsync(int Id)
        {
            return await ShopContext.Products.Include(p => p.Sites).FirstOrDefaultAsync(p => p.Id == Id);
        }
        public async Task<List<Product>> GetProductsByCategoryAsync(string name, int page, int pageSize)
        {
            return await ShopContext.Products.OrderBy(p => p.Id) .Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
        }
        public async Task<int> GetProductsCountByCategoryAsync(string category)
        {
            return await ShopContext.Products.CountAsync();
        }
    }
}