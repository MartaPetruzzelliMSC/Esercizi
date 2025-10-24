using Test0001.Models;

namespace Test0001.Dtos
{
    public class CommentDto : BaseEntity
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
