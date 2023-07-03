using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using scrapapp.entity;

namespace scrapapp.webui.Models
{
    public class ProductViewModel
    {
        public PageInfo PageInfo { get; set; }
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
    }
}