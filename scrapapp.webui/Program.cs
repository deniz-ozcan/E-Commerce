using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using scrapapp.business.Abstract;
using scrapapp.business.Concrete;
using scrapapp.data.Abstract;
using scrapapp.data.Concrete.EfCore;

namespace scrapapp.webui
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddControllersWithViews();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();
            if (env.IsDevelopment())
            {
                SeedDatabase.Seed();
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "adminproducts", 
                    pattern: "Admin/Products",
                    defaults: new {controller="Admin",action="Index"}
                );
                endpoints.MapControllerRoute(
                    name: "adminproductcreate", 
                    pattern: "Admin/Products/Create",
                    defaults: new {controller="Admin",action="Create"}
                );
                endpoints.MapControllerRoute(
                    name: "adminproductedit", 
                    pattern: "Admin/Products/{slug?}",
                    defaults: new {controller="Admin",action="Edit"}
                );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{slug?}"
                );
            });
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
