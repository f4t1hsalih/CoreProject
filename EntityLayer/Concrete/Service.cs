using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        public required string Title { get; set; }
        [Url]
        public required string ImageUrl { get; set; }
    }
}
