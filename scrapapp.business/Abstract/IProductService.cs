using scrapapp.entity;

namespace scrapapp.business.Abstract
{
    public interface IProductService
    {
        Product GetByslug(string slug);
        List<Product> GetAll(int page, int pageSize);
        List<Product> GetByFilter(string brand, string system, string storage, string ram, string screen, double? min_price, double? max_price, double? rate, int page, int pageSize);
        List<Product> GetBySearch(string q, int page, int pageSize);
        int GetCountsByFilter(string brand, string system, string storage, string ram, string screen, double? min_price, double? max_price, double? rate);
        int GetCounts();
        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
    }
}