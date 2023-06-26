using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using scrapapp.business.Abstract;
using scrapapp.entity;
using scrapapp.webui.Models;

namespace scrapapp.webui.Controllers
{
    public class AdminController : Controller
    {
        private IProductService _productService;

        public AdminController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult Index(int page = 1)
        {

            var productViewModel = new ProductViewModel()
            {
                PageInfo = new PageInfo() { TotalItems = _productService.GetCounts(), CurrentPage = page, ItemsPerPage = 10 },
                Products = _productService.GetAll(page, 10)
            };
            return View(productViewModel);
        }
        [HttpPost]
        public IActionResult Delete(string slug)
        {
            _productService.Delete(_productService.GetByslug(slug));
            return RedirectToAction("Index");
        }
    }
}