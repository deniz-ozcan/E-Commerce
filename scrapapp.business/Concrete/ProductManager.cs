using scrapapp.business.Abstract;
using scrapapp.data.Abstract;
using scrapapp.entity;

namespace scrapapp.business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _product;
        public ProductManager(IProductRepository product)
        {
            _product = product;
        }
        public void Create(Product entity)
        {
            _product.Create(entity);
        }
        public void Update(Product entity)
        {
            _product.Update(entity);
        }
        public void Delete(Product entity)
        {
            _product.Delete(entity);
        }
        public List<Product> GetAll(int page, int pageSize)
        {
            return _product.GetAll(page, pageSize);
        }
        public Product GetByslug(string slug)
        {
            return _product.GetByslug(slug);
        }
        public int GetCounts()
        {
            return _product.GetCounts();
        }
        public int GetCountsByFilter(string brand, string system, string storage, string ram, string screen, double? min_price, double? max_price, double? rate)
        {
            return _product.GetCountsByFilter(brand, system, storage, ram, screen, min_price, max_price, rate);
        }
        public List<Product> GetByFilter(string brand, string system, string storage, string ram, string screen, double? min_price, double? max_price, double? rate,int page, int pageSize)
        {
            return _product.GetByFilter(brand, system, storage, ram, screen, min_price, max_price, rate, page, pageSize);
        }
        public List<Product> GetBySearch(string q, int page, int pageSize)
        {
            return _product.GetBySearch(q, page, pageSize);
        }
    }
}