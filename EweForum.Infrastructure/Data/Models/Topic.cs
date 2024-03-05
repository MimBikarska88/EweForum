using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EweForum.Infrastructure.Data.Models
{
    public  class Topic
    {
        [Key]
        public int Id { get; set; } 
        public string Description { get; set; }  = string.Empty;
        public string Title { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set;}

        public string ForumUserId { get; set; } = string.Empty;

        [ForeignKey(nameof(ForumUserId))] 

        public ForumUser? ForumUser { get; set; }

        public bool IsActive { get; set; }  

        public virtual IEnumerable<JoinedTopic> JoinedTopics { get; set; } = new List<JoinedTopic>();

        public virtual IEnumerable<Post>Posts { get; set; }  = new LinkedList<Post>();
    }
}
