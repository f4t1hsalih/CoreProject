using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]  // primary key
        public int Id { get; set; }

        [StringLength(100)]  // varchar(100)
        public string? Title { get; set; }

        [StringLength(500)]  // varchar(500)
        public string? Description { get; set; }

        public int? Age { get; set; }

        [StringLength(50)]   // varchar(50)
        public string? Email { get; set; }

        [StringLength(20)]   // varchar(20)
        public string? Phone { get; set; }

        [StringLength(200)]  // varchar(200)
        public string? Address { get; set; }

        [StringLength(200)]  // varchar(200)
        public string? ImageUrl { get; set; }
    }
}
