using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]  // varchar(100)
        public string? Name { get; set; }

        [StringLength(100)]  // varchar(100)
        public string? Email { get; set; }

        [StringLength(500)]  // varchar(500)
        public string? Content { get; set; }

        public DateTime Date { get; set; }

        public bool Status { get; set; }
    }
}
