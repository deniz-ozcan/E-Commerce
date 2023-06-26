using Microsoft.AspNetCore.Mvc;
using scrapapp.business.Abstract;
using scrapapp.webui.Models;

namespace scrapapp.webui.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;
        public HomeController(IProductService productService)
        {
            this._productService = productService;
        }
        public IActionResult Index(int page = 1)
        {

            Categories categories = new Categories();
            var productViewModel = new ProductViewModel()
            {
                PageInfo = new PageInfo() { TotalItems = _productService.GetCounts(), CurrentPage = page, ItemsPerPage = 24 },
                categories = categories.categories,
                Products = _productService.GetAll(page, 24)
            };
            return View(productViewModel);
        }
        [HttpGet]
        public IActionResult Detail(string slug)
        {
            return View(_productService.GetByslug(slug));
        }

        public IActionResult FilterProducts(string search, string brand, string system, string storage, string ram, string screen, double? min_price, double? max_price, double? rate, string sort, int page = 1)
        {
            Console.WriteLine("brand: " + brand);
            Console.WriteLine("system: " + system);
            Console.WriteLine("storage: " + storage);
            Console.WriteLine("ram: " + ram);
            Console.WriteLine("screen: " + screen);
            Console.WriteLine("min_price: " + min_price);
            Console.WriteLine("max_price: " + max_price);
            Console.WriteLine("rate: " + rate);
            Console.WriteLine("sort: " + sort);
            if (brand == null) { brand = ""; }
            if (system == null) { system = ""; }
            if (storage == null) { storage = ""; }
            if (ram == null) { ram = ""; }
            if (screen == null) { screen = ""; }

            var Brand = brand.Split(",").ToList();
            var System = system.Split(",").ToList();
            var Storage = storage.Split(",").ToList();
            var Ram = ram.Split(",").ToList();
            var Screen = screen.Split(",").ToList();
            Categories categories = new Categories();
            foreach (var item in categories.categories)
            {
                if (item.Key == "Brand")
                {
                    for (int i = 0; i < Brand.Count; i++)
                    {
                        for (int j = 0; j < item.Value.Count; j++)
                        {
                            if (Brand[i] == item.Value[j].Name)
                            {
                                item.Value[j].isChecked = true;
                            }
                        }
                    }
                }
                else if (item.Key == "System")
                {
                    for (int i = 0; i < System.Count; i++)
                    {
                        for (int j = 0; j < item.Value.Count; j++)
                        {
                            if (System[i] == item.Value[j].Name)
                            {
                                item.Value[j].isChecked = true;
                            }
                        }
                    }
                }
                else if (item.Key == "Storage")
                {
                    for (int i = 0; i < Storage.Count; i++)
                    {
                        for (int j = 0; j < item.Value.Count; j++)
                        {
                            if (Storage[i] == item.Value[j].Name)
                            {
                                item.Value[j].isChecked = true;
                            }
                        }
                    }
                }
                else if (item.Key == "Ram")
                {
                    for (int i = 0; i < Ram.Count; i++)
                    {
                        for (int j = 0; j < item.Value.Count; j++)
                        {
                            if (Ram[i] == item.Value[j].Name)
                            {
                                item.Value[j].isChecked = true;
                            }
                        }
                    }
                }
                else if (item.Key == "Screen")
                {
                    for (int i = 0; i < Screen.Count; i++)
                    {
                        for (int j = 0; j < item.Value.Count; j++)
                        {
                            if (Screen[i] == item.Value[j].Name)
                            {
                                item.Value[j].isChecked = true;
                            }
                        }
                    }
                }
            }
            Dictionary<string, List<string>> checkcategories = new Dictionary<string, List<string>> { { "Brand", Brand }, { "System", System }, { "Storage", Storage }, { "Ram", Ram }, { "Screen", Screen } };
            var products = _productService.GetByFilter(search, checkcategories, min_price, max_price, rate, sort, page, 24);
            var totatItems = _productService.GetCountsByFilter(search, checkcategories, min_price, max_price, rate);
            var productViewModel = new ProductViewModel()
            {
                PageInfo = new PageInfo() { TotalItems = totatItems, CurrentPage = page, ItemsPerPage = 24 },
                categories = categories.categories,
                Products = products
            };
            return View("Index", productViewModel);
        }
    }
}