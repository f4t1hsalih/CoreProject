using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Portfolio
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        [Url]
        public required string ProjectUrl { get; set; }
        [Url]
        public required string SmallImageUrl { get; set; }
        [Url]
        public required string ImageUrl { get; set; }
    }
}
