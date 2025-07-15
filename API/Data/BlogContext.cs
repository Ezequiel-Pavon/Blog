using Microsoft.EntityFrameworkCore;

namespace Blog.API.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<FriendRequest> FriendRequests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure entity relationships and constraints here
            base.OnModelCreating(modelBuilder);
        }
    }
}