using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using scrapapp.business.Abstract;
using scrapapp.entity;
using scrapapp.webui.Models;

namespace scrapapp.webui.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }
        public async Task<IActionResult> Index(string category, int page = 1)
        {
            return View(new ProductViewModel()
            {
                PageInfo = new PageInfo()
                {
                    TotalItems = await _productService.GetProductsCountByCategoryAsync(category),
                    CurrentPage = page,
                    ItemsPerPage = 24,
                    CurrentCategory = category
                },
                Products = await _productService.GetProductsByCategoryAsync(category, page, 24)
            });
        }
        public async Task<IActionResult> Detail(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            Product product = await _productService.GetByIdAsync(id);
            return product == null ? NotFound() : View(product);
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