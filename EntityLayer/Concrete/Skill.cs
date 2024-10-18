using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]  // varchar(100)
        public string? Title { get; set; }

        [StringLength(500)]  // varchar(500)
        public string? Value { get; set; }
    }
}
