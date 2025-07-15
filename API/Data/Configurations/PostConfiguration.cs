using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Blog.API.Models;

namespace Blog.API.Data.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            // Configure the table name
            builder.ToTable("Posts");

            // Configure the primary key
            builder.HasKey(p => p.Id);

            // Configure properties
            builder.Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(p => p.Body)
                .IsRequired();

            builder.Property(p => p.ImageUrl)
                .HasMaxLength(500);

            builder.Property(p => p.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            // Configure relationships
            builder.HasOne<User>()
                .WithMany(u => u.Posts)
                .HasForeignKey(p => p.AuthorId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}