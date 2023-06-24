using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using scrapapp.entity;

namespace scrapapp.webui.ViewModels
{
    public class ProductViewModel
    {
        public PageInfo PageInfo { get; set; }
        public List<Product> Products { get; set; }
    }
}