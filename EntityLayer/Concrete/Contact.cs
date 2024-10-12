using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        [EmailAddress]
        public required string EMail { get; set; }
        [Phone]
        public required string Phone { get; set; }
    }
}
