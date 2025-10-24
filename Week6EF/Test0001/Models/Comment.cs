using System.ComponentModel.DataAnnotations.Schema;

namespace Test0001.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CreationDate { get; set; } = DateTime.UtcNow;

        [Column(TypeName = "smalldatetime")]
        public DateTime UpdateDate { get; set; } = DateTime.UtcNow;
        public int UserId { get; set; }
        public User User { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public string Content { get; set; }
    }
}
