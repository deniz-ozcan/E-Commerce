using Microsoft.EntityFrameworkCore;
using scrapapp.data.Concrete.EfCore;
using scrapapp.webui.Identity;

namespace scrapapp.webui.Extensions
{
    public static class MigrationManager
    {
        public static IHost MigrateDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                using (var applicationContext = scope.ServiceProvider.GetRequiredService<ApplicationContext>())
                {
                    try
                    {
                        applicationContext.Database.Migrate();
                    }
                    catch (System.Exception)
                    {
                        throw;
                    }
                }
                using var shopContext = scope.ServiceProvider.GetRequiredService<ShopContext>();
                try
                {
                    shopContext.Database.Migrate();
                }
                catch (System.Exception)
                {
                    throw;
                }
            }
            return host;
        }
    }
}