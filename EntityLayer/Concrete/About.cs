using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public int Age { get; set; }
        [EmailAddress]
        public required string Email { get; set; }
        [Phone]
        public required string Phone { get; set; }
        public required string Address { get; set; }
        [Url]
        public required string ImageUrl { get; set; }
    }
}