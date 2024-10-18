using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class SocialMedia
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]  // varchar(100)
        public string? Name { get; set; }

        [StringLength(200)]  // varchar(200)
        public string? Url { get; set; }

        [StringLength(100)]  // varchar(100)
        public string? Icon { get; set; }

        public bool Status { get; set; }
    }
}
