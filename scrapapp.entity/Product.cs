using System.ComponentModel.DataAnnotations;
namespace scrapapp.entity
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Screen { get; set; }
        [Required]
        public string Ram { get; set; }
        [Required]
        public string Processor { get; set; }
        [Required]
        public string Storage { get; set; }
        [Required]
        public string System { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public bool isUpdated { get; set; }
        [Required]
        public double Rate { get; set; }
        public List<Site> Sites { get; set; }
    }
}