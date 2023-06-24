using System.Linq;
using Microsoft.EntityFrameworkCore;
using scrapapp.entity;
namespace scrapapp.data.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var sitesInfo = new List<SitesInformation>();
            var details = new List<Detail>();
            var sites = File.ReadAllLines("../scrapapp.data/Concrete/EfCore/InitialData/siteInformations.csv");
            
            foreach (var line in sites)
            {
                var fields = line.Split(',');
                sitesInfo.Add(new SitesInformation { SitesInformationId = int.Parse(fields[0]), Link = fields[1], Rate = float.Parse(fields[2]), Price = float.Parse(fields[3]), SiteName = fields[4], ProductId = int.Parse(fields[5]) });
            }
            var pros = File.ReadAllLines("../scrapapp.data/Concrete/EfCore/InitialData/Products.csv");
            foreach (var line in pros)
            {
                var fields = line.Split(',');
                details.Add(new Detail {DetailId = int.Parse(fields[0]), Name = fields[2], Model = fields[1], Processor = fields[6], Ram = fields[5], Screen = fields[4], Storage = fields[7], System = fields[8], Image = fields[9], Slug = fields[3] });
            }
            var products = new List<Product>();
            float price = 0.0f, rate = 0.0f;
            int count = 0;
            for (int i = 0; i < details.Count; i++)
            {
                var info = new List<SitesInformation>();
                for (int j = 0; j < sitesInfo.Count; j++)
                {
                    if (details[i].DetailId == sitesInfo[j].ProductId)
                    {
                        info.Add(sitesInfo[j]);
                        price = info[0].Price;
                        rate = info[0].Rate;
                        count++;
                    }
                }
                products.Add(new Product { ProductId = details[i].DetailId, Detail = details[i], SitesInformation = info, Price = price, Rate = rate, is_updated = false });
            }
            var context = new ShopContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(products);
                }
            }
            context.SaveChanges();
        }
    }
}