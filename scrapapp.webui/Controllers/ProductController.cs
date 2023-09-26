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
        public async Task<IActionResult> Index(string q, int page = 1)
        {
            return View(new ProductViewModel()
            {
                PageInfo = new PageInfo()
                {
                    TotalItems = await _productService.GetProductsCountByCategoryAsync(q),
                    CurrentPage = page,
                    ItemsPerPage = 24,
                    CurrentCategory = q
                },
                Products = await _productService.GetProductsByCategoryAsync(q, page, 24)
            });
        }
        public async Task<IActionResult> Detail(int id)
        {
            if (id < 1)
            {
                return await Task.FromResult<IActionResult>(BadRequest());
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