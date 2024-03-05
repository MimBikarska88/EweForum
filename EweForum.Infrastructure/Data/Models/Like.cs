using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EweForum.Infrastructure.Data.Models
{
    public class Like
    {
        public int PostId { get; set; }
        [ForeignKey(nameof(PostId))]
        public Post Post { get; set; } = null!;


        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public ForumUser User { get; set; }= null!;
    }
}
