using System.Collections.Generic;

namespace scrapapp.data.Abstract
{
    public interface IRepository<T>
    {
        T GetByslug(string slug);
        int GetCounts();
        int GetCountsByFilter(string search, Dictionary<string, List<string>> categories, double? min_price, double? max_price, double? rate);
        List<T> GetByFilter(string search, Dictionary<string, List<string>> categories, double? min_price, double? max_price, double? rate, string sort, int page, int pageSize);
        List<T> GetAll(int page, int pageSize);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}