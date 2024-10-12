using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Testimonial
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Company { get; set; }
        public required string Comment { get; set; }
        [Url]
        public required string ImageUrl { get; set; }
    }
}
