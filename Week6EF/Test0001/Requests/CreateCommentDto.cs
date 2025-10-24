using Test0001.Models;

namespace Test0001.Requests
{
    public class CreateCommentDto
    {
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public string Content { get; set; }
    }
}
