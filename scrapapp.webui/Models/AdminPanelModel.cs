using Microsoft.AspNetCore.Identity;
using scrapapp.webui.Identity;
using scrapapp.entity;

namespace scrapapp.webui.Models
{
    public class AdminPanelModel
    {
        public IEnumerable<IdentityRole> Roles { get; set; }
        public IEnumerable<User> Users { get; set; }
        public List<Product> Products { get; set; }
    }
}