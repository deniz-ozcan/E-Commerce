using System.ComponentModel.DataAnnotations;
namespace scrapapp.entity
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public int DetailId { get; set; }
        [Required]
        public Detail Detail { get; set; }
        [Required]
        public float Rate { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public bool is_updated { get; set; }
        [Required]
        public List<SitesInformation> SitesInformation { get; set; }
    }
}