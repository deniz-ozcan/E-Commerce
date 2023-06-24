using scrapapp.data.Abstract;
using scrapapp.entity;
using Microsoft.EntityFrameworkCore;
namespace scrapapp.data.Concrete.EfCore
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetAll(int page, int pageSize)
        {
            using (var context = new ShopContext())
            {
                return context.Products.Select(
                    i => new Product
                    {
                        Detail = i.Detail,
                        SitesInformation = i.SitesInformation,
                        Rate = i.Rate ,
                        Price = i.Price ,
                        is_updated = i.is_updated
                    }
                ).Skip((page - 1) * pageSize).Take(pageSize).ToList();
            }
        }

        public List<Product> GetByFilter(string brand, string system, string storage, string ram, string screen, double? min_price, double? max_price, double? rate,int page, int pageSize)
        {
            using (var context = new ShopContext())
            {
                return context.Products.Select(
                    i => new Product
                    {
                        Detail = i.Detail,
                        SitesInformation = i.SitesInformation,
                        Rate = i.Rate ,
                        Price = i.Price ,
                        is_updated = i.is_updated
                    }
                ).Where(i => 
                    (brand != null ? i.Detail.Name == brand : true) &&
                    (system != null ? i.Detail.System == system : true) &&
                    (storage != null ? i.Detail.Storage == storage : true) &&
                    (ram != null ? i.Detail.Ram == ram : true) &&
                    (screen != null ? i.Detail.Screen == screen : true) &&
                    (min_price != null ? i.Price >= min_price : true) &&
                    (max_price != null ? i.Price <= max_price : true) &&
                    (rate != null ? i.Rate >= rate : true)
                ).Skip((page - 1) * pageSize).Take(pageSize).ToList();
            }
        }
        
        public int GetCountsByFilter(string brand, string system, string storage, string ram, string screen, double? min_price, double? max_price, double? rate)
        {
            using (var context = new ShopContext())
            {
                return context.Products.Select(
                    i => new Product
                    {
                        Detail = i.Detail,
                        SitesInformation = i.SitesInformation,
                        Rate = i.Rate ,
                        Price = i.Price ,
                        is_updated = i.is_updated
                    }
                ).Where(i => 
                    (brand != null ? i.Detail.Name == brand : true) &&
                    (system != null ? i.Detail.System == system : true) &&
                    (storage != null ? i.Detail.Storage == storage : true) &&
                    (ram != null ? i.Detail.Ram == ram : true) &&
                    (screen != null ? i.Detail.Screen == screen : true) &&
                    (min_price != null ? i.Price >= min_price : true) &&
                    (max_price != null ? i.Price <= max_price : true) &&
                    (rate != null ? i.Rate >= rate : true)
                ).Count();
            }
        }
        public List<Product> GetBySearch(string q, int page, int pageSize)
        {
            using (var context = new ShopContext())
            {
                return context.Products.Select(
                    i => new Product
                    {
                        Detail = i.Detail,
                        SitesInformation = i.SitesInformation,
                        Rate = i.Rate ,
                        Price = i.Price ,
                        is_updated = i.is_updated
                    }
                ).Where(i => 
                    i.Detail.Name.Contains(q) || 
                    i.Detail.Model.Contains(q) || 
                    i.Detail.Ram.Contains(q) || 
                    i.Detail.Storage.Contains(q) || 
                    i.Detail.Processor.Contains(q) || 
                    i.Detail.System.Contains(q) || 
                    i.Detail.Screen.Contains(q)
                ).Skip((page - 1) * pageSize).Take(pageSize).ToList();
            }
        }
        public int GetCounts()
        {
            using (var context = new ShopContext())
            {
                return context.Products.Select(
                    i => new Product
                    {
                        Detail = i.Detail,
                        SitesInformation = i.SitesInformation,
                        Rate = i.Rate ,
                        Price = i.Price ,
                        is_updated = i.is_updated
                    }
                ).Count();
            }
        }
        public Product GetByslug(string slug)
        {
            using (var context = new ShopContext())
            {
                return context.Products.Select(
                    i => new Product
                    {
                        Detail = i.Detail,
                        SitesInformation = i.SitesInformation,
                        Rate = i.Rate ,
                        Price = i.Price ,
                        is_updated = i.is_updated
                    }
                ).ToList().FirstOrDefault(i => i.Detail.Slug == slug);
            }
        }
        public void Create(Product entity)
        {
            using (var context = new ShopContext())
            {
                context.Products.Add(entity);
                context.SaveChanges();
            }
        }
        public void Delete(Product entity)
        {
            using (var context = new ShopContext())
            {
                context.Products.Remove(entity);
                context.SaveChanges();
            }
        }
        public void Update(Product entity)
        {
            using (var context = new ShopContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}

