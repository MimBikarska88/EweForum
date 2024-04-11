using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EweForum.Infrastructure.Data.Models
{
    public class PostReply
    {
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public ForumUser ForumUser { get; set; } = null!;

        public int PostId { get; set; }
        [ForeignKey(nameof(PostId))]

        public Post Post { get; set; } = null!;

        [Column(TypeName = "Text")]
        public string Content { get; set; } = String.Empty;


        public DateTime CreatedOn { get; set; } 

        public DateTime ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        [InverseProperty(nameof(ReplyClosure.Child))]
        public virtual List<ReplyClosure> Parents { get; set; } = new List<ReplyClosure>();


        [InverseProperty(nameof(ReplyClosure.Parent))]
        public virtual List<ReplyClosure> Children { get; set; } = new List<ReplyClosure>();

       
    }
}
