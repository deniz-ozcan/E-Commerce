using System.Collections.Generic;

namespace scrapapp.data.Abstract
{
    public interface IRepository<T>
    {
        T GetByslug(string slug);
        int GetCounts();
        List<T> GetByFilter(string brand, string system, string storage, string ram, string screen, double? min_price, double? max_price, double? rate, int page, int pageSize);
        List<T> GetBySearch(string q, int page, int pageSize);
        int GetCountsByFilter(string brand, string system, string storage, string ram, string screen, double? min_price, double? max_price, double? rate);
        List<T> GetAll(int page, int pageSize);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}