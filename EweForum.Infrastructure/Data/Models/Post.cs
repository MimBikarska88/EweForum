using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EweForum.Infrastructure.Data.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string ForumUserId { get; set; } = string.Empty;

        [ForeignKey(nameof(ForumUserId))]
        public ForumUser ForumUser { get; set; } = null!;

        public int TopicId { get; set; }
        [ForeignKey(nameof(TopicId))]
        public Topic Topic { get; set; } = null!;

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;


        public virtual IEnumerable<PostAttachment> PostsAttachments { get; set; } = new List<PostAttachment>();
        public virtual IEnumerable<Like>Likes { get; set; } = new LinkedList<Like>();

        public virtual IEnumerable<PostReply> PostsReplies { get; set; }  = new LinkedList<PostReply>();


    }
}
