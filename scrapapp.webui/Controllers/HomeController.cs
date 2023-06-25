using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using scrapapp.business.Abstract;
using scrapapp.entity;
using scrapapp.webui.ViewModels;

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
            var productViewModel = new ProductViewModel()
            {
                PageInfo = new PageInfo()
                {
                    TotalItems = _productService.GetCounts(),
                    CurrentPage = page,
                    ItemsPerPage = 24,
                },
                Products = _productService.GetAll(page, 24)
            };
            return View(productViewModel);
        }
        [HttpGet]
        public IActionResult Detail(string slug)
        {
            return View(_productService.GetByslug(slug));
        }

        public IActionResult FilterProducts(string search, List<string> brand, List<string> system, List<string> storage, List<string> ram, List<string> screen, double? min_price, double? max_price, double? rate, string sort,int page = 1)
        {
            Dictionary<string, List<string>> categories = new Dictionary<string, List<string>>{{"Brand",brand},{"System",system},{"Storage",storage},{"Ram",ram},{"Screen",screen}};
            var products = _productService.GetByFilter(search, categories, min_price, max_price, rate, sort, page, 24);
            var totatItems = _productService.GetCountsByFilter(search, categories, min_price, max_price, rate);
            var productViewModel = new ProductViewModel()
            {
                PageInfo = new PageInfo()
                {
                    TotalItems = totatItems,
                    CurrentPage = page,
                    ItemsPerPage = 24,
                },
                Products = products
            };
            return View("Index", productViewModel);
        }
    }
}