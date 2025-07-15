using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Blog.API.Models;

namespace Blog.API.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // Configure the table name
            builder.ToTable("Users");

            // Configure the primary key
            builder.HasKey(u => u.Id);

            // Configure properties
            builder.Property(u => u.UserName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(u => u.ProfilePictureUrl)
                .HasMaxLength(200);
        }
    }
}