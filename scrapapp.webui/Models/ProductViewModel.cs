using scrapapp.entity;

namespace scrapapp.webui.Models
{
    public class PageInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public string CurrentCategory { get; set; }

        public int TotalPages()
        {
            return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
        }
        public int HasPrevious()
        {
            if (CurrentPage > 1)
            {
                return 1;
            }
            return 0;
        }
        public int HasNext()
        {
            if (CurrentPage < TotalPages())
            {
                return 1;
            }
            return 0;
        }
    }

    public class ProductViewModel
    {
        public PageInfo PageInfo { get; set; }
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
    }
}