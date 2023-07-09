using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using scrapapp.business.Abstract;
using scrapapp.entity;
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
        public IActionResult Index(string category, int page = 1)
        {
            return View(new ProductViewModel()
            {
                PageInfo = new PageInfo()
                {
                    TotalItems = _productService.GetCountByCategory(category),
                    CurrentPage = page,
                    ItemsPerPage = 24,
                    CurrentCategory = category
                },
                Products = _productService.GetProductsByCategory(category, page, 24)
            });
        }
        public IActionResult Detail(string slug)
        {
            if (slug == null)
            {
                return NotFound();
            }
            Product product = _productService.GetProductDetails(slug);
            return product == null ? NotFound() : View(product);
        }
        public IActionResult Search(string q)
        {
            var productViewModel = new ProductViewModel()
            {
                Products = _productService.GetSearchResult(q)
            };
            return View("Index", productViewModel);
        }
        public async Task<IActionResult> RestApi()
        {
            var products = new List<Product>();
            using (var httpClient = new HttpClient())
            {
                using var response = await httpClient.GetAsync("http://localhost:4200/api/products");
                string apiResponse = await response.Content.ReadAsStringAsync();
                products = JsonConvert.DeserializeObject<List<Product>>(apiResponse);
            }
            return View(products);
        }
    }
}