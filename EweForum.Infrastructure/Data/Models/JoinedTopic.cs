using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EweForum.Infrastructure.Data.Models
{
    public class JoinedTopic
    {
        public string ForumUserId { get; set; }  = string.Empty;

        [ForeignKey(nameof(ForumUserId))]
        public ForumUser ForumUser { get; set; } = null!;

        public int TopicId { get; set; }
        [ForeignKey(nameof(TopicId))]
        public Topic Topic { get; set; } = null!;   
        
    }
}
