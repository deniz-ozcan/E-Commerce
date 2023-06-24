using Microsoft.EntityFrameworkCore;
using scrapapp.entity;

namespace scrapapp.data.Concrete.EfCore
{
    public class ShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Detail> details { get; set; }
        public DbSet<SitesInformation> sitesInformation { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=db.sqlite3");
        }
    }
}