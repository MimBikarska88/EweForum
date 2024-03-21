using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EweForum.Infrastructure.Data.Models
{
    public class ForumUser : IdentityUser
    {
        [Column(TypeName = "text")]
        public string PersonalInfo { get; set; } = string.Empty;

        public DateTime CreatedOn { get; set; }

        public DateTime ModifiedOn { get; set; }    

        public bool IsActive { get; set; }
        public virtual IEnumerable<ForumUserAttachment> ForumUsersFilesAttachments { get; set; } = new List<ForumUserAttachment>();

        public virtual IEnumerable<Topic>CreatedTopics { get; set; } = new List<Topic>();
        public virtual IEnumerable<JoinedTopic> JoinedTopics { get; set; } = new List<JoinedTopic>();

        public virtual IEnumerable<Post> Posts { get; set; } = new LinkedList<Post>();

        public virtual IEnumerable<Like> Likes { get; set; } = new List<Like>();

        public string CountryId { get; set; } = string.Empty;

        [ForeignKey(nameof(CountryId))]
        public Country? Country { get; set; } = null!;


    }
}
