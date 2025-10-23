using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationEF.Dtos;
using WebApplicationEF.Models;

namespace WebApplicationEF.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommentsController : ControllerBase
    {
        private readonly DatabaseFirstDbContext _context;

        public CommentsController(DatabaseFirstDbContext context)
        {
            _context = context;
        }

        // GET: api/comments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CommentDto>>> GetComments()
        {
            var query = _context.Comments
                .Select(x => new CommentDto
                {
                    Id = x.Id,
                    CommentContent = x.CommentContent,
                    CreatedAt = x.CreatedAt,
                    ProductId = x.ProductId
                });
            return await query.ToListAsync();
        }

        //GET api/comments/1
        [HttpGet("{id}")]
        public async Task<ActionResult<CommentDto>> GetComment(int id)
        {
            var comment = await _context.Comments.AsNoTracking()
                .Select(x => new CommentDto
                {
                    Id = x.Id,
                    CommentContent = x.CommentContent,
                    CreatedAt = x.CreatedAt,
                    ProductId = x.ProductId
                }).FirstOrDefaultAsync(c => c.Id == id);
           
            if (comment == null) return NotFound();

            return comment;
        }

        //POST api/comments
        [HttpPost]
        public async Task<ActionResult<CommentDto>> CreateComment(CreateCommentDto comment)
        {
            var productExists = await _context.Products
                .AnyAsync(p => p.Id == comment.ProductId);

            if (!productExists)
                return BadRequest($"Product with Id {comment.ProductId} does not exist.");

            var c = _context.Comments.Add(new Comment
            {
                CommentContent = comment.CommentContent,
                ProductId = comment.ProductId
            }).Entity;

            await _context.SaveChangesAsync();

            //return Ok();

            return new CommentDto
            {
                Id = c.Id,
                CommentContent = c.CommentContent,
                CreatedAt = c.CreatedAt,
                ProductId = c.ProductId
            };
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateComment(int id, UpdateCommentDto updateComment)
        {
            //if (id != updateComment.Id)
            //    return BadRequest();

            var existingComment = await _context.Comments.FindAsync(id);
            if (existingComment == null)
                return NotFound();

            //var existingProduct = await _context.Products.FindAsync(updateComment.ProductId);
            //if (existingProduct == null)
            //    return BadRequest($"Product with ID {updateComment.ProductId} does not exist.");

            existingComment.CommentContent = updateComment.CommentContent;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComment(int id)
        {
            var comment = await _context.Comments.FindAsync(id);
            if (comment == null)
                return NotFound();

            _context.Comments.Remove(comment);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
