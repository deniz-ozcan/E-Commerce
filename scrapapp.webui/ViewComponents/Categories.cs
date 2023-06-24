using Microsoft.AspNetCore.Mvc;
namespace scrapapp.webui.ViewModels
{
    public class Categories:ViewComponent
    {
        Dictionary<string, List<string>> categories = new Dictionary<string, List<string>>();

        public IViewComponentResult Invoke()
        {
            List<string> screens = new List<string>{"13INC","13.3INC","13.4INC","13.5INC","13.6INC","13.9INC","14INC","14.2INC","14.5INC","15INC","15.6INC","16INC","16.1INC","17INC","17.3INC"};
            List<string> brands = new List<string>{"ACER", "APPLE", "HP", "HUAWEI", "ASUS", "DELL", "CASPER", "LENOVO", "MSI"};
            List<string> rams = new List<string>{"4GB","8GB","12GB","16GB","20GB","24GB","32GB","36GB","40GB","48GB","64GB"};
            List<string> systems = new List<string>{"W10","W10P","W11","W11P","FREEDOS","LINUX","UBUNTU","MACOS"};
            List<string> storages = new List<string>{"128GB","256GB","512GB","1TB","2TB"};
            categories.Add("Brand",brands);
            categories.Add("System",systems);
            categories.Add("Storage",storages);
            categories.Add("Ram",rams);
            categories.Add("Screen",screens);
            return View(categories);
        }
    }
}

