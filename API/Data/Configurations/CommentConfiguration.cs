using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Blog.API.Models;

namespace Blog.API.Data.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            // Configure the table name
            builder.ToTable("Comments");

            // Configure the primary key
            builder.HasKey(c => c.Id);

            // Configure properties
            builder.Property(c => c.Body)
                .IsRequired()
                .HasMaxLength(500); // Example length constraint

            // Configure relationships
            builder.HasOne<User>()
                .WithMany(u => u.Comments)
                .HasForeignKey(c => c.AuthorId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<Post>()
                .WithMany(p => p.Comments)
                .HasForeignKey(c => c.PostId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<Comment>()
                .WithMany(c => c.Replies)
                .HasForeignKey(c => c.ParentCommentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}