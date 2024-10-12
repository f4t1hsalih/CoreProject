using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class SocialMedia
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        [Url]
        public string? Url { get; set; }
        public string? Icon { get; set; }
        public bool Status { get; set; }
    }
}
