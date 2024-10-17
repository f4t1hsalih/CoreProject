using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Experience
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Date { get; set; }
        [Url]
        public required string ImageUrl { get; set; }
        public string? Description { get; set; }
    }
}
