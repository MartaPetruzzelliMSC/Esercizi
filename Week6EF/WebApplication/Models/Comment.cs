using System;
using System.Collections.Generic;

namespace WebApplicationEF.Models;

public partial class Comment
{
    public int Id { get; set; }

    public string? CommentContent { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? ProductId { get; set; }

    public virtual Product? Product { get; set; }
}
