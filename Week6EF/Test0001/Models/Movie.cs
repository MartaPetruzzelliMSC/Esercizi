using System.ComponentModel.DataAnnotations.Schema;

namespace Test0001.Models
{
    public class Movie : BaseEntity
    {
        public string Title { get; set; }

        [Column(TypeName = "date")]
        public DateOnly ReleaseDate { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public IEnumerable<Comment> Comments { get; set; }

        public IEnumerable<User> Users { get; set; }

        public IEnumerable<Director> Directors { get; set; }
    }
}
