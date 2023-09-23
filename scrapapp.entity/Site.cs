using System.ComponentModel.DataAnnotations;
namespace scrapapp.entity
{

    public class Site
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Url { get; set; }
        [Required]
        public double Rate { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string SiteName { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
} 
