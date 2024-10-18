using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Experience
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]  // varchar(100)
        public string? Name { get; set; }

        [StringLength(20)]  // varchar(20)
        public string? Date { get; set; }  

        [StringLength(200)]  // varchar(200)
        public string? ImageUrl { get; set; }

        [StringLength(500)]  // varchar(500), opsiyonel açıklama
        public string? Description { get; set; }
    }
}
