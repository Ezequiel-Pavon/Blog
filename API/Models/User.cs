using System;
using System.Collections.Generic;

namespace Blog.API.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string ProfilePictureUrl { get; set; }

        // Navigation properties
        public ICollection<Post> Posts { get; set; }
        public ICollection<Like> Likes { get; set; }
        public ICollection<FriendRequest> SentFriendRequests { get; set; }
        public ICollection<FriendRequest> ReceivedFriendRequests { get; set; }
    }
}