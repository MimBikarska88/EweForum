using EweForum.Utilites.Enums;
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

        public DateTime CreatedOn { get; set; }

        public DateTime ModifiedOn { get; set; }

        public string ForumUserId { get; set; } = string.Empty;

        [ForeignKey(nameof(ForumUserId))]
        public ForumUser ForumUser { get; set; } = null!;

        public int TopicId { get; set; }
        [ForeignKey(nameof(TopicId))]
        public Topic Topic { get; set; } = null!;

        public string Title { get; set; } = string.Empty;

        public string EventDescription { get; set; } = string.Empty;

        public string EventTitle { get; set; } = string.Empty;

        public string VideoTitle { get; set; } = string.Empty;
 
        public string VideoDescription { get; set; } = string.Empty;


        [Column(TypeName = "text")]
        public string Content { get; set; } = string.Empty;
        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public string VideoUrl { get; set; } = string.Empty;

        public PostType PostType { get; set; } 

        public virtual IEnumerable<PostAttachment> PostsAttachments { get; set; } = new List<PostAttachment>();
        public virtual IEnumerable<Like>Likes { get; set; } = new LinkedList<Like>();

        public virtual IEnumerable<PostReply> PostsReplies { get; set; }  = new LinkedList<PostReply>();


    }
}
