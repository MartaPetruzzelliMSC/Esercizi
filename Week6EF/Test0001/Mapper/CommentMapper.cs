using Test0001.Dtos;
using Test0001.Models;
using Test0001.Requests;

namespace Test0001.Mapper
{
    public static class CommentMapper
    {
        public static CommentDto ToDto(this Comment comment)
        {
            return new CommentDto
            {
                Id = comment.Id,
                CreationDate = comment.CreationDate,
                UpdateDate = comment.UpdateDate,
                UserId = comment.UserId,
                Username = comment.User.Username,
                MovieId = comment.MovieId,
                Title = comment.Movie.Title,
                Content = comment.Content
            };
        }

        public static Comment ToModel(this CreateCommentDto comment)
        {
            return new Comment
            {
                UserId = comment.UserId,
                MovieId = comment.UserId,
                Content = comment.Content
            };
        }
    }
}
