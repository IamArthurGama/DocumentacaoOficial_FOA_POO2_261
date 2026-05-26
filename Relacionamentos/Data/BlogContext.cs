using Microsoft.EntityFrameworkCore;
using Relacionamentos.Models;

namespace Relacionamentos.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options) { }

        public DbSet<Blog> Blogs => Set<Blog>();
        public DbSet<Post> Posts => Set<Post>();
    }
}
