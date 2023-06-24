using System.ComponentModel.DataAnnotations;
namespace scrapapp.entity
{
    public class Detail
    {
        public int DetailId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Ram { get; set; }
        [Required]
        public string Storage { get; set; }
        [Required]
        public string Processor { get; set; }
        [Required]
        public string System { get; set; }
        [Required]
        public string Screen { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Slug { get; set; }
    }
}

