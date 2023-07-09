using Learning_Blog.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Learning_Blog.Data
{
    public class LearningBlogDbContext : DbContext
    {
        public LearningBlogDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
