using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Portfolio
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]  // varchar(100)
        public string? Name { get; set; }

        [StringLength(200)]  // varchar(200)
        public string? ProjectUrl { get; set; }

        [StringLength(200)]  // varchar(200)
        public string? SmallImageUrl { get; set; }

        [StringLength(200)]  // varchar(200)
        public string? ImageUrl { get; set; }
    }
}
