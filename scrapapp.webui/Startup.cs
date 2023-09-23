using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using scrapapp.business.Abstract;
using scrapapp.business.Concrete;
using scrapapp.data.Abstract;
using scrapapp.data.Concrete.EfCore;
using scrapapp.webui.EmailServices;
using scrapapp.webui.Identity;

namespace scrapapp.webui
{
    public class Startup
    {
        private IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>(options => options.UseSqlite(_configuration.GetConnectionString("SqliteConnection")));
            services.AddDbContext<ShopContext>(options => options.UseSqlite(_configuration.GetConnectionString("SqliteConnection")));
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();
            services.Configure<IdentityOptions>(options =>
            {
                // password
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = true;

                // Lockout                
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.AllowedForNewUsers = true;

                // options.User.AllowedUserNameCharacters = "";
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = true;
                options.SignIn.RequireConfirmedPhoneNumber = false;
            });

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Account/Login";
                options.LogoutPath = "/Account/Logout";
                options.AccessDeniedPath = "/Account/AccessDenied";
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = TimeSpan.FromDays(30);
                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true,
                    Name = ".ScrapApp.Security.Cookie",
                    SameSite = SameSiteMode.Strict
                };
            });

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<ICartService, CartManager>();
            services.AddScoped<IOrderService, OrderManager>();

            services.AddScoped<IEmailSender, SmtpEmailSender>(i =>
                new SmtpEmailSender(
                    _configuration["EmailSender:Host"],
                    _configuration.GetValue<int>("EmailSender:Port"),
                    _configuration.GetValue<bool>("EmailSender:EnableSSL"),
                    _configuration["EmailSender:UserName"],
                    _configuration["EmailSender:Password"])
                );

            services.AddControllersWithViews();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IConfiguration configuration, UserManager<User> userManager, RoleManager<IdentityRole> roleManager, ICartService cartService)
        {
            app.UseStaticFiles(); // wwwroot
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "Orders",
                    pattern: "Orders",
                    defaults: new { controller = "Cart", action = "GetOrders" }
                );
                endpoints.MapControllerRoute(
                    name: "Checkout",
                    pattern: "Checkout",
                    defaults: new { controller = "Cart", action = "Checkout" }
                );
                endpoints.MapControllerRoute(
                    name: "Cart",
                    pattern: "Cart",
                    defaults: new { controller = "Cart", action = "Index" }
                );
                endpoints.MapControllerRoute(
                    name: "AdminUserEdit",
                    pattern: "Admin/User/{id?}",
                    defaults: new { controller = "Admin", action = "UserUpdate" }
                );
                endpoints.MapControllerRoute(
                    name: "AdminUsers",
                    pattern: "Admin/User/List",
                    defaults: new { controller = "Admin", action = "UserList" }
                );
                endpoints.MapControllerRoute(
                    name: "AdminRoleEdit",
                    pattern: "Admin/Role/{id?}",
                    defaults: new { controller = "Admin", action = "RoleUpdate" }
                );
                endpoints.MapControllerRoute(
                    name: "AdminRoles",
                    pattern: "Admin/Role/List",
                    defaults: new { controller = "Admin", action = "RoleList" }
                );
                endpoints.MapControllerRoute(
                    name: "AdminRoleCreate",
                    pattern: "Admin/Role/Create",
                    defaults: new { controller = "Admin", action = "RoleCreate" }
                );
                endpoints.MapControllerRoute(
                    name: "AdminProducts",
                    pattern: "Admin/Products",
                    defaults: new { controller = "Admin", action = "Products" }
                );
                endpoints.MapControllerRoute(
                    name: "Search",
                    pattern: "Search",
                    defaults: new { controller = "Product", action = "Search" }
                );
                endpoints.MapControllerRoute(
                    name: "ProductDetails",
                    pattern: "{url}",
                    defaults: new { controller = "Product", action = "Detail" }
                );
                endpoints.MapControllerRoute(
                    name: "Product",
                    pattern: "Product",
                    defaults: new { controller = "Product", action = "Index" }
                );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Product}/{action=Index}/{id?}"
                );
            });
            SeedIdentity.Seed(userManager, roleManager, cartService, configuration).Wait();
        }
    }
}
