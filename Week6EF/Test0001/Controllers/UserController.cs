using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test0001.Dtos;
using Test0001.Mapper;
using Test0001.Models;
using Test0001.Requests;

namespace Test0001.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly CodeFirstDbContext _context;

        public UserController(CodeFirstDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetUsers()
        {
            var u = _context.Users.AsNoTracking()
                .Select(x => x.ToDto());
            return await u.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserDto>> GetUserById(int id)
        {
            var u = await  _context.Users
                .AsNoTracking()
               .Select(x => x.ToDto())
               .FirstOrDefaultAsync(x => x.Id == id);
            if (u == null)
                return NotFound();
            return u;
        }

        [HttpGet("{id}/comments")]
        public async Task<ActionResult<IEnumerable<CommentDto>>> GetCommentsByUserId(int id)
        {
            var user = await _context.Users.AnyAsync(u => u.Id == id);
            if (!user)
                return NotFound();

            var comments = _context.Comments.AsNoTracking().Include(c => c.User)
                .Select(x => new CommentDto
                {
                    Id = x.Id,
                    UserId = x.UserId,
                    Username = x.User.Username,
                    MovieId = x.MovieId,
                    Title = x.Movie.Title,
                    Content = x.Content
                })
                .Where(c => c.UserId == id);

            return await comments.ToListAsync();
        }

        //[HttpGet("{id}/bookmarks")]
        //public async Task<ActionResult<IEnumerable<MovieDto>>> GetBookmarksByUserId(int id)
        //{
        //    var user = await _context.Users.AnyAsync(u => u.Id == id);
        //    if (!user)
        //        return NotFound();

        //    //var bookmarks = _context.Movies.AsNoTracking()
        //    //    .Include(b => b.Users).ThenInclude(u => u.Movies)
        //    //    .Select(x => x.ToDto());
        //    var bookmarks = _context.Users.AsNoTracking()
        //        .Include(b => b.Movies)
        //        .Select(x => x.Movies.Select(m => m.ToDto())).ToListAsync();

        //    return bookmarks;
        //}

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserDto user)
        {
            var u = _context.Users.Add(user.ToModel());
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, CreateUserDto user)
        {
            var existingUser = await _context.Users.FindAsync(id);
            if(existingUser == null)
                return NotFound();

            existingUser.Username = user.Username;
            existingUser.Email = user.Email;

            await _context.SaveChangesAsync();

            return NoContent();

        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
                return NotFound();

            _context.Users.Remove(user);

            await _context.SaveChangesAsync();

            return NoContent();

        }
    }
}
