using System.ComponentModel.DataAnnotations.Schema;

namespace Test0001.Requests
{
    public class CreateMovieDto
    {
        public string Title { get; set; }

        public DateOnly ReleaseDate { get; set; }

        public int CategoryId { get; set; }
    }
}
