using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using scrapapp.business.Abstract;
using scrapapp.data.Abstract;
using scrapapp.entity;
using scrapapp.webui.Models;

namespace scrapapp.webui.Controllers
{
    // localhost:5000/home
    public class HomeController : Controller
    {
        private IProductService _productService;
        public HomeController(IProductService productService)
        {
            this._productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var productViewModel = new ProductListViewModel()
            {
                Products = await _productService.GetAll()
            };
            return View(productViewModel);
        }

        public async Task<IActionResult> RestApi()
        {
            var products = new List<Product>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:4200/api/products"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    products = JsonConvert.DeserializeObject<List<Product>>(apiResponse);
                }
            }
            return View(products);
        }
    }
}