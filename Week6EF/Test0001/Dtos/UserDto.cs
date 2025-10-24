using Test0001.Models;

namespace Test0001.Dtos
{
    public class UserDto : BaseEntity
    {

        public string Username { get; set; }

        public string Email { get; set; }

        //public IEnumerable<CommentDto> Comments { get; set; }

        //public IEnumerable<MovieDto> Bookmarks { get; set; }
    }
}
