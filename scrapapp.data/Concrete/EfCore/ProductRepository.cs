// using scrapapp.data.Abstract;
// using scrapapp.entity;
// using Microsoft.EntityFrameworkCore;
// namespace scrapapp.data.Concrete.EfCore
// {
//     public class ProductRepository : IProductRepository
//     {
//         public List<Product> GetAll(int page, int pageSize)
//         {
//             using (var context = new ShopContext())
//             {
//                 return context.Products
//                     .Select(i => new Product{Detail = i.Detail, SitesInformation = i.SitesInformation, Rate = i.Rate, Price = i.Price, is_updated = i.is_updated})
//                     .Skip((page - 1) * pageSize).Take(pageSize).ToList();
//             }
//         }

//         public int GetCounts()
//         {
//             using (var context = new ShopContext())
//             {
//                 return context.Products
//                     .Select(i => new Product{Detail = i.Detail, SitesInformation = i.SitesInformation, Rate = i.Rate, Price = i.Price, is_updated = i.is_updated})
//                     .Count();
//             }
//         }
//         public List<Product> GetByFilter(string search, List<string> categories, double? min_price, double? max_price, double? rate, string sort, int page, int pageSize)
//         {


//             using (var context = new ShopContext())
//             {
//                 return context.Products
//                     .Select(i => new Product{Detail = i.Detail, SitesInformation = i.SitesInformation, Rate = i.Rate, Price = i.Price, is_updated = i.is_updated})
//                     .Count();
//                 var query = context.Products.AsQueryable();

//                 if (Brand.Any())
//                 {
//                     query = query
//                 }
//                 if (Storage.Any())
//                 {
//                     query = query.Where(p => Storage.Contains(p.Detail.Storage));
//                 }
//                 if (Screen.Any())
//                 {
//                     query = query.Where(p => Screen.Contains(p.Detail.Screen));
//                 }
//                 if (System.Any())
//                 {
//                     query = query.Where(p => System.Contains(p.Detail.System));
//                 }
//                 if (Ram.Any())
//                 {
//                     query = query.Where(p => Ram.Contains(p.Detail.Ram));
//                 }
//                 if (min_price != null)
//                 {
//                     query = query.Where(p => p.Price >= min_price);
//                 }
//                 if (max_price != null)
//                 {
//                     query = query.Where(p => p.Price <= max_price);
//                 }
//                 if (rate != null)
//                 {
//                     query = query.Where(p => p.Rate >= rate);
//                 }
//                 if (!string.IsNullOrEmpty(search))
//                 {
//                     query = query.Where(p => p.Detail.Name.Contains(search) || p.Detail.Model.Contains(search) || p.Detail.Ram.Contains(search) || p.Detail.Storage.Contains(search));
//                 }
//                 if (sort == "price_asc")
//                 {
//                     query = query.OrderBy(p => p.Price);
//                 }
//                 else if (sort == "price_desc")
//                 {
//                     query = query.OrderByDescending(p => p.Price);
//                 }
//                 else if (sort == "rate_asc")
//                 {
//                     query = query.OrderBy(p => p.Rate);
//                 }
//                 else if (sort == "rate_desc")
//                 {
//                     query = query.OrderByDescending(p => p.Rate);
//                 }
//                 else
//                 {
//                     query = query.OrderBy(p => p.Price);
//                 }
//                 return query
//                     .Select(i => new Product{Detail = i.Detail, SitesInformation = i.SitesInformation, Rate = i.Rate, Price = i.Price, is_updated = i.is_updated})
//                     .Skip((page - 1) * pageSize).Take(pageSize).ToList();
//             }
//         }
        
//         public int GetCountsByFilter(string search, List<string>> categories, double? min_price, double? max_price, double? rate)
//         {
//             List<string> Brand = categories["Brand"];
//             List<string> Storage = categories["Storage"];
//             List<string> Screen = categories["Screen"];
//             List<string> System = categories["System"];
//             List<string> Ram = categories["Ram"];

//             using (var context = new ShopContext())
//             {
//                 var query = context.Products.AsQueryable();

//                 if (Brand.Any())
//                 {
//                     query = query.Where(p => Brand.Contains(p.Detail.Name));
//                 }
//                 if (Storage.Any())
//                 {
//                     query = query.Where(p => Storage.Contains(p.Detail.Storage));
//                 }
//                 if (Screen.Any())
//                 {
//                     query = query.Where(p => Screen.Contains(p.Detail.Screen));
//                 }
//                 if (System.Any())
//                 {
//                     query = query.Where(p => System.Contains(p.Detail.System));
//                 }
//                 if (Ram.Any())
//                 {
//                     query = query.Where(p => Ram.Contains(p.Detail.Ram));
//                 }
//                 if (min_price != null)
//                 {
//                     query = query.Where(p => p.Price >= min_price);
//                 }
//                 if (max_price != null)
//                 {
//                     query = query.Where(p => p.Price <= max_price);
//                 }
//                 if (rate != null)
//                 {
//                     query = query.Where(p => p.Rate >= rate);
//                 }
//                 if (!string.IsNullOrEmpty(search))
//                 {
//                     query = query.Where(p => p.Detail.Name.Contains(search) || p.Detail.Model.Contains(search) || p.Detail.Ram.Contains(search) || p.Detail.Storage.Contains(search));
//                 }
//                 return query
//                     .Select(i => new Product{Detail = i.Detail, SitesInformation = i.SitesInformation, Rate = i.Rate, Price = i.Price, is_updated = i.is_updated})
//                     .Count();
//             }
//         }
    
//         public Product GetByslug(string slug)
//         {
//             using (var context = new ShopContext())
//             {
//                 return context.Products.Select(
//                     i => new Product
//                     {
//                         Detail = i.Detail,
//                         SitesInformation = i.SitesInformation,
//                         Rate = i.Rate ,
//                         Price = i.Price ,
//                         is_updated = i.is_updated
//                     }
//                 ).ToList().FirstOrDefault(i => i.Detail.Slug == slug);
//             }
//         }
//         public void Create(Product entity)
//         {
//             using (var context = new ShopContext())
//             {
//                 context.Products.Add(entity);
//                 context.SaveChanges();
//             }
//         }
//         public void Delete(Product entity)
//         {
//             using (var context = new ShopContext())
//             {
//                 context.Products.Remove(entity);
//                 context.SaveChanges();
//             }
//         }
//         public void Update(Product entity)
//         {
//             using (var context = new ShopContext())
//             {
//                 context.Entry(entity).State = EntityState.Modified;
//                 context.SaveChanges();
//             }
//         }
//     }
// }

