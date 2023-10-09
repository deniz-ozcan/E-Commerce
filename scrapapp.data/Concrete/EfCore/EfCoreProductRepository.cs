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
            return await ShopContext.Products.ToListAsync();
        }
        public async Task<Product> GetByIdAsync(int Id)
        {
            return await ShopContext.Products.Include(p => p.Sites).FirstOrDefaultAsync(p => p.Id == Id);
        }
        public async Task<List<Product>> GetProducts(string q, int page, int pageSize)
        {
            var products = ShopContext
                .Products.Include(i => i.Sites).OrderBy(p => p.Id)
                .AsQueryable();
            if (!string.IsNullOrEmpty(q))
            {
                products = products
                    .Include(i => i.Sites)
                    .Where(p => p.Brand.ToLower() == q.ToLower());
            }
            return await products.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
        }
        public async Task<int> GetProductsCount(string q)
        {
            return await ShopContext.Products.CountAsync();
        }
    }
}