using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using scrapapp.business.Abstract;
using scrapapp.webui.Models;

namespace scrapapp.webui.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        public IViewComponentResult InvokeAsync()
        {
            List<Category> categories = new List<Category> {
                new Category { CategoryId = 1, Name = "ACER"},
                new Category { CategoryId = 2, Name = "APPLE"},
                new Category { CategoryId = 3, Name = "HP"},
                new Category { CategoryId = 4, Name = "HUAWEI"},
                new Category { CategoryId = 5, Name = "ASUS"},
                new Category { CategoryId = 6, Name = "DELL"},
                new Category { CategoryId = 7, Name = "CASPER"},
                new Category { CategoryId = 8, Name = "LENOVO"},
                new Category { CategoryId = 9, Name = "MSI"}
            };
            if (RouteData.Values["category"] != null)
                ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(categories);
        }
    }
}