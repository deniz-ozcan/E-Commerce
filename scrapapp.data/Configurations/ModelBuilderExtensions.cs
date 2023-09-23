using Microsoft.EntityFrameworkCore;
using scrapapp.entity;

namespace scrapapp.data.Configurations
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            var sitesInfo = new List<Site>();
            var details = new List<Product>();
            var products = new List<Product>();
            decimal price = 0;
            double rate = 0.0f;
            var sites = File.ReadAllLines("../scrapapp.data/Configurations/InitialData/siteInformations.csv");
            foreach (var line in sites)
            {
                var fields = line.Split(',');
                sitesInfo.Add(new Site { Id = int.Parse(fields[0]), Url = fields[1], Rate = float.Parse(fields[2]), Price = decimal.Parse(fields[3]), SiteName = fields[4], ProductId = int.Parse(fields[5]) });
            }
            var pros = File.ReadAllLines("../scrapapp.data/Configurations/InitialData/Products.csv");
            foreach (var line in pros)
            {
                var fields = line.Split(',');
                details.Add(new Product { Id = int.Parse(fields[0]), Brand = fields[1], Model = fields[2], Screen = fields[3], Ram = fields[4], Processor = fields[5], Storage = fields[6], System = fields[7], Image = fields[8]});
            }
            for (int i = 0; i < details.Count; i++)
            {
                var info = new List<Site>();
                for (int j = 0; j < sitesInfo.Count; j++)
                {
                    if (details[i].Id == sitesInfo[j].ProductId)
                    {
                        info.Add(sitesInfo[j]);
                        price = info[0].Price;
                        rate = info[0].Rate;
                    }
                }
                var product = new Product
                {
                    Id = details[i].Id,
                    Brand = details[i].Brand,
                    Model = details[i].Model,
                    Screen = details[i].Screen,
                    Ram = details[i].Ram,
                    Processor = details[i].Processor,
                    Storage = details[i].Storage,
                    System = details[i].System,
                    Image = details[i].Image,
                    Price = price,
                    Rate = rate,
                    isUpdated = false,
                    Sites = info
                };
                products.Add(product);
                info.Clear();
            }
            details.Clear();
            builder.Entity<Site>().HasData(sitesInfo.ToArray());
            builder.Entity<Product>().HasData(products.ToArray());
            products.Clear();
            sitesInfo.Clear();
        }
    }
}