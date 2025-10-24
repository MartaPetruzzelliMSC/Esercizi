using System.ComponentModel.DataAnnotations.Schema;

namespace Test0001.Models
{
    public class User
    {
        public int Id { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CreationDate { get; set; } = DateTime.UtcNow;

        [Column(TypeName = "smalldatetime")]
        public DateTime UpdateDate { get; set; } = DateTime.UtcNow;
        public string Username { get; set; }
        public string Email { get; set; }
        public IEnumerable<Comment> Comments { get; set; }

        public IEnumerable<Movie> Movies { get; set; }

    }
}
