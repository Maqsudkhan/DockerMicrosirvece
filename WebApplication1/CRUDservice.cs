using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.Provider;

namespace WebApplication1
{
    public class CRUDservice : ICRUDservice
    {
        private readonly MicroseviceDBContext _context;

        public CRUDservice(MicroseviceDBContext context)
        {
            _context = context;
        }

        public async Task<BlogPost> CreatePost(BlogPost post)
        {
            var result = await _context.Posts.AddAsync(post);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<List<BlogPost>> GetAllPosts()
        {
            var result = await _context.Posts.ToListAsync();
            return result;
        }
    }
}
