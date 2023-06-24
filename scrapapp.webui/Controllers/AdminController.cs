using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json; // Newtonsoft.Json ile ekleyebilirsin.
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
        // public IActionResult ProductList()
        // {
        //     return View(new ProductListViewModel()
        //     {
        //         Products = _productService.GetAll()
        //     });
        // }

        // [HttpGet]
        // public IActionResult ProductCreate()
        // {
        //     return View();
        // }

        // [HttpPost]
        // public IActionResult ProductCreate(ProductModel model)
        // {
        //     var entity = new Product()
        //     {
        //         Name = model.Name,
        //         Url = model.Url,
        //         Price = model.Price,
        //         Description = model.Description,
        //         ImageUrl = model.ImageUrl
        //     };

        //     _productService.Create(entity);

        //     var msg = new AlertMessage()
        //     {
        //         Message = $"{entity.Name} isimli ürün eklendi.",
        //         AlertType = "success"
        //     };

        //     TempData["message"] = JsonConvert.SerializeObject(msg);

        //     // {"Message":"samsung isimli ürün eklendi.","AlertType":"success"}

        //     return RedirectToAction("ProductList");
        // }



        // [HttpGet]
        // public IActionResult ProductEdit(int? id)
        // {
        //     if (id == null)
        //     {
        //         return NotFound();
        //     }

        //     var entity = _productService.GetByIdWithCategories((int)id);

        //     if (entity == null)
        //     {
        //         return NotFound();
        //     }

        //     var model = new ProductModel()
        //     {
        //         ProductId = entity.ProductId,
        //         Name = entity.Name,
        //         Url = entity.Url,
        //         Price = entity.Price,
        //         ImageUrl = entity.ImageUrl,
        //         Description = entity.Description,
        //         SelectedCategories = entity.ProductCategories.Select(i => i.Category).ToList()
        //     };

        //     ViewBag.Categories = _categoryService.GetAll();

        //     return View(model);
        // }

        // [HttpPost]
        // public IActionResult ProductEdit(ProductModel model, int[] categoryIds)
        // {
        //     var entity = _productService.GetById(model.ProductId);
        //     if (entity == null)
        //     {
        //         return NotFound();
        //     }
        //     entity.Name = model.Name;
        //     entity.Price = model.Price;
        //     entity.Url = model.Url;
        //     entity.ImageUrl = model.ImageUrl;
        //     entity.Description = model.Description;

        //     _productService.Update(entity, categoryIds);

        //     var msg = new AlertMessage()
        //     {
        //         Message = $"{entity.Name} isimli ürün güncellendi.",
        //         AlertType = "success"
        //     };

        //     TempData["message"] = JsonConvert.SerializeObject(msg);

        //     return RedirectToAction("ProductList");
        // }
    }
}