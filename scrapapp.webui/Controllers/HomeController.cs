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

        public IActionResult FilterProducts(string brand, string system, string storage, string ram, string screen, double? min_price, double? max_price, double? rate, int page = 1)
        {
            var productViewModel = new ProductViewModel()
            {
                PageInfo = new PageInfo()
                {
                    TotalItems = _productService.GetCountsByFilter(brand, system, storage, ram, screen, min_price, max_price, rate),
                    CurrentPage = page,
                    ItemsPerPage = 24,
                },
                Products = _productService.GetByFilter(brand, system, storage, ram, screen, min_price, max_price, rate, page, 24)
            };
            return View("Index",productViewModel);
        }
        [HttpGet]
        public IActionResult Search(string q, int page = 1)
        {
            var productViewModel = new ProductViewModel()
            {
                PageInfo = new PageInfo()
                {
                    TotalItems = _productService.GetCounts(),
                    CurrentPage = page,
                    ItemsPerPage = 24,
                },
                Products = _productService.GetBySearch(q, page, 24)
            };
            return View(_productService.GetAll(1, 24));
        }
    }
}