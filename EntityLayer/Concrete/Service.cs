using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Service
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]  // varchar(100)
        public string? Title { get; set; }

        [StringLength(200)]  // varchar(200)
        public string? ImageUrl { get; set; }
    }
}
