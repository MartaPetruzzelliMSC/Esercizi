namespace WebApplicationEF.Dtos
{
    public class CommentDto
    {
        public int Id { get; set; }

        public string? CommentContent { get; set; }

        public DateTime? CreatedAt { get; set; } 

        public int? ProductId { get; set; }

    }
}
