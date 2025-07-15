using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Blog.API.Models;

namespace Blog.API.Data.Configurations
{
    public class FriendRequestConfiguration : IEntityTypeConfiguration<FriendRequest>
    {
        public void Configure(EntityTypeBuilder<FriendRequest> builder)
        {
            builder.HasKey(fr => fr.Id);

            builder.HasOne(fr => fr.FromUser)
                  .WithMany(u => u.SentFriendRequests)
                  .HasForeignKey(fr => fr.FromUserId)
                  .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(fr => fr.ToUser)
                  .WithMany(u => u.ReceivedFriendRequests)
                  .HasForeignKey(fr => fr.ToUserId)
                  .OnDelete(DeleteBehavior.Restrict);
        }
    }
}