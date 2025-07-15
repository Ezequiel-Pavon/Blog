using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Blog.API.Models;

namespace Blog.API.Data.Configurations
{
    public class LikeConfiguration : IEntityTypeConfiguration<Like>
    {
        public void Configure(EntityTypeBuilder<Like> builder)
        {
            // Configure the table name
            builder.ToTable("Likes");

            // Configure the primary key
            builder.HasKey(l => l.Id);

            // Configure properties
            builder.Property(l => l.UserId)
                .IsRequired();

            builder.Property(l => l.PostId)
                .IsRequired(false);

            builder.Property(l => l.CommentId)
                .IsRequired(false);

            builder.Property(l => l.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            // Configure relationships
            builder.HasOne<User>()
                .WithMany(u => u.Likes)
                .HasForeignKey(l => l.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<Post>()
                .WithMany(p => p.Likes)
                .HasForeignKey(l => l.PostId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<Comment>()
                .WithMany(c => c.Likes)
                .HasForeignKey(l => l.CommentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}