using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Provider
{
    public class MicroseviceDBContext : DbContext
    {
        public MicroseviceDBContext(DbContextOptions<MicroseviceDBContext> options) : base(options)
        {
            
        }
        public virtual DbSet<BlogPost> Posts { get; set; }
    }
}
