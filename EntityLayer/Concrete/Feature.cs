using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Feature
    {
        [Key]
        public int Id { get; set; }

        [StringLength(200)]  // varchar(200)
        public string? Header { get; set; }

        [StringLength(100)]  // varchar(100)
        public string? Name { get; set; }

        [StringLength(150)]  // varchar(150)
        public string? Title { get; set; }
    }
}
