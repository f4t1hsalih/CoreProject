using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]  // varchar(100)
        public required string Username { get; set; }

        [StringLength(100)]  // varchar(100)
        public required string Password { get; set; }

    }
}
