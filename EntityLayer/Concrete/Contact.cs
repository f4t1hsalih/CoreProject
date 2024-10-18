using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]  // varchar(100)
        public string? Title { get; set; }

        [StringLength(500)]  // varchar(500)
        public string? Description { get; set; }

        [StringLength(100)]  // varchar(100)
        public string? Email { get; set; }

        [StringLength(20)]   // varchar(20)
        public string? Phone { get; set; }
    }
}
