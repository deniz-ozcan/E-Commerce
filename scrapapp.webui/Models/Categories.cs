using Microsoft.AspNetCore.Mvc;

namespace scrapapp.webui.Models
{
    public class Categories
    {
        public List<Category> storages = new List<Category>{new Category{Name = "128GB", isChecked = false}, new Category{Name = "256GB", isChecked = false}, new Category{Name = "512GB", isChecked = false}, new Category{Name = "1TB", isChecked = false}, new Category{Name = "2TB", isChecked = false}};
        public List<Category> screens = new List<Category>{new Category{Name = "13INC", isChecked = false}, new Category{Name = "13.3INC ",  isChecked=false}, new Category{Name = "13.4INC ",  isChecked=false}, new Category{Name = "13.5INC ",  isChecked=false}, new Category{Name = "13.6INC ",  isChecked=false}, new Category{Name = "13.9INC ",  isChecked=false}, new Category{Name = "14INC", isChecked = false}, new Category{Name = "14.2INC ",  isChecked=false}, new Category{Name = "14.5INC ",  isChecked=false}, new Category{Name = "15INC", isChecked = false}, new Category{Name = "15.6INC ",  isChecked=false}, new Category{Name = "16INC", isChecked = false}, new Category{Name = "16.1INC ",  isChecked=false}, new Category{Name = "17INC", isChecked = false}, new Category{Name = "17.3INC ",  isChecked=false}};
        public List<Category> systems = new List<Category>{new Category{Name = "W10", isChecked = false}, new Category{Name = "W10P", isChecked = false}, new Category{Name = "W11", isChecked = false}, new Category{Name = "W11P", isChecked = false}, new Category{Name = "FREEDOS", isChecked = false}, new Category{Name = "LINUX", isChecked = false}, new Category{Name = "UBUNTU", isChecked = false}, new Category{Name = "MACOS", isChecked = false}};
        public List<Category> brands = new List<Category>{new Category{Name = "ACER", isChecked = false}, new Category{Name = "APPLE", isChecked = false}, new Category{Name = "HP", isChecked = false}, new Category{Name = "HUAWEI", isChecked = false}, new Category{Name = "ASUS", isChecked = false}, new Category{Name = "DELL", isChecked = false}, new Category{Name = "CASPER", isChecked = false}, new Category{Name = "LENOVO", isChecked = false}, new Category{Name = "MSI", isChecked = false}};
        public List<Category> rams = new List<Category>{new Category{Name = "4GB", isChecked = false}, new Category{Name = "8GB", isChecked = false}, new Category{Name = "12GB", isChecked = false}, new Category{Name = "16GB", isChecked = false}, new Category{Name = "20GB", isChecked = false}, new Category{Name = "24GB", isChecked = false}, new Category{Name = "32GB", isChecked = false}, new Category{Name = "36GB", isChecked = false}, new Category{Name = "40GB", isChecked = false}, new Category{Name = "48GB", isChecked = false}, new Category{Name = "64GB", isChecked = false}};
        public Dictionary<string, List<Category>> categories;
        public Categories()
        {
            Dictionary<string, List<Category>> categories = new Dictionary<string, List<Category>>();
            categories.Add("Brand", brands);
            categories.Add("System", systems);
            categories.Add("Storage", storages);
            categories.Add("Ram", rams);
            categories.Add("Screen", screens);
            this.categories = categories;
        }
    }
}

