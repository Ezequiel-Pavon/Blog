using System;
using Blog.API.Models.Enums;

namespace Blog.API.Models
{
    public class FriendRequest
    {
        public Guid Id { get; set; }
        public Guid FromUserId { get; set; }
        public Guid ToUserId { get; set; }
        public FriendRequestStatus Status { get; set; }
        public DateTime Timestamp { get; set; }

        // Navigation properties
        public virtual User FromUser { get; set; }
        public virtual User ToUser { get; set; }
    }
}
