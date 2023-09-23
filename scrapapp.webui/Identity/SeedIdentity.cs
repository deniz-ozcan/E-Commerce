using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using scrapapp.business.Abstract;

namespace scrapapp.webui.Identity
{
    public static class SeedIdentity
    {
        public static async Task Seed(UserManager<User> userManager, RoleManager<IdentityRole> roleManager,ICartService cartService,IConfiguration configuration)
        {
            var roles = configuration.GetSection("Data:Roles").GetChildren().Select(x=>x.Value).ToArray();
            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
            var users = configuration.GetSection("Data:Users");
            foreach (var section in users.GetChildren())
            {
                Console.WriteLine(section.GetValue<string>("username"));
                var username = section.GetValue<string>("username");
                var password = section.GetValue<string>("password");
                var email = section.GetValue<string>("email");
                var role = section.GetValue<string>("role");
                var firstName = section.GetValue<string>("firstName");
                var lastName = section.GetValue<string>("lastName");
                if(await userManager.FindByNameAsync(username)==null)
                {
                    Console.WriteLine(username);
                    var user = new User()
                    {
                        UserName = username,
                        Email = email,
                        FirstName = firstName,
                        LastName = lastName,
                        EmailConfirmed = true
                    };
                    var result = await userManager.CreateAsync(user,password);
                    if(result.Succeeded)
                    {
                        Console.WriteLine(username);
                        await userManager.AddToRoleAsync(user,role);
                        cartService.InitializeCart(user.Id);
                    }
                }
                
            }
        }
    }
}