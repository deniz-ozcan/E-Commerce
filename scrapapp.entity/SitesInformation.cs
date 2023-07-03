using System.ComponentModel.DataAnnotations;
namespace scrapapp.entity
{
    public class SitesInformation
    {
        public int SitesInformationId { get; set; }
        [Required]
        public string Link { get; set; }
        [Required]
        public float Rate { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public string SiteName { get; set; }
        [Required]
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
