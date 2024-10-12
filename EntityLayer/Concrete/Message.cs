using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string EMail { get; set; }
        public required string Content { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}
