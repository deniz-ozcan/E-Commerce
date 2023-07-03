using System.Collections.Generic;
using scrapapp.entity;

namespace scrapapp.webui.Models
{
    public class ProductDetailModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}