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
        public int GetCountsByFilter(string search, Dictionary<string, List<string>> categories, double? min_price, double? max_price, double? rate)
        {
            return _product.GetCountsByFilter(search, categories, min_price, max_price, rate);
        }
        public List<Product> GetByFilter(string search, Dictionary<string, List<string>> categories, double? min_price, double? max_price, double? rate, string sort, int page, int pageSize)
        {
            return _product.GetByFilter(search, categories, min_price, max_price, rate, sort, page, pageSize);
        }
    }
}