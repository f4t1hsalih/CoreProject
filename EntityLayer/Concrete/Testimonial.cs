using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Testimonial
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]  // varchar(100)
        public string? Name { get; set; }

        [StringLength(50)]  // varchar(50)
        public string? Position { get; set; }

        [StringLength(100)]  // varchar(100)
        public string? Company { get; set; }

        [StringLength(500)]  // varchar(500)
        public string? Comment { get; set; }

        [StringLength(200)]  // varchar(200)
        public string? ImageUrl { get; set; }
    }
}
