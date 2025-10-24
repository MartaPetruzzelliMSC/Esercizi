using System.ComponentModel.DataAnnotations.Schema;
using Test0001.Models;

namespace Test0001.Dtos
{
    public class MovieDto : BaseEntity
    {
        public string Title { get; set; }

        [Column(TypeName = "date")]
        public DateOnly ReleaseDate { get; set; }

        public int CategoryId { get; set; }

        //public IEnumerable<CommentDto> Comments { get; set; }

        //public IEnumerable<DirectorDto> Directors { get; set; }
    }
}
