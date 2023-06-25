using scrapapp.entity;

namespace scrapapp.business.Abstract
{
    public interface IProductService
    {
        Product GetByslug(string slug);
        List<Product> GetAll(int page, int pageSize);
        int GetCounts();
        List<Product> GetByFilter(string search, Dictionary<string, List<string>> categories, double? min_price, double? max_price, double? rate, string sort, int page, int pageSize);
        int GetCountsByFilter(string search, Dictionary<string, List<string>> categories, double? min_price, double? max_price, double? rate);
        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
    }
}