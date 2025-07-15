using System;
using System.Collections.Generic;


namespace Blog.API.Models
{
    public class Comment
    {
        public Guid Id { get; set; }
        public Guid PostId { get; set; }
        public Guid AuthorId { get; set; }
        public Guid? ParentCommentId { get; set; }
        public string Body { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigation properties
        public virtual Post Post { get; set; }
        public virtual User Author { get; set; }
        public ICollection<Like> Likes { get; set; } = new List<Like>();
        public virtual Comment ParentComment { get; set; }
        public virtual ICollection<Comment> Replies { get; set; }
    }
}