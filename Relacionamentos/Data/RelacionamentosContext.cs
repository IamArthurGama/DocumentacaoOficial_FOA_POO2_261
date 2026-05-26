using Microsoft.EntityFrameworkCore;
using Relacionamentos.Models;

namespace Relacionamentos.Data
{
    public class RelacionamentosContext : DbContext
    {
        public RelacionamentosContext(DbContextOptions<RelacionamentosContext> options) : base(options) { }

        public DbSet<Blog> Blogs => Set<Blog>();
        public DbSet<Post> Posts => Set<Post>();
    }
}
