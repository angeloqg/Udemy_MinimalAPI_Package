using System.ComponentModel.DataAnnotations;

namespace MinimalAPI.Delivery.Entities
{
    public class Location
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Latitude { get; set; }

        [Required]
        public string Longitude { get; set; }
    }
}
