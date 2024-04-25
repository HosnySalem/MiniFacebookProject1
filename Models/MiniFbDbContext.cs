using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MiniFacebookProject1.Models
{
    public class MiniFbDbContext : IdentityDbContext<User>
    {
        public MiniFbDbContext(DbContextOptions<MiniFbDbContext> options):base(options) { }

        public virtual DbSet<Post> Posts { get; set; }
    }
}
