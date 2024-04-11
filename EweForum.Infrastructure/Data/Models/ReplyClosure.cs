using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EweForum.Infrastructure.Data.Models
{
    public class ReplyClosure
    {
        [Key]
        public int Id { get; set; }

        public int ParentId { get; set; }

        [ForeignKey(nameof(ParentId))]

        public PostReply Parent { get; set; } = null!;

        public int ChildId { get; set; }
        [ForeignKey(nameof(ChildId))]
        public PostReply Child { get; set; } = null!;

        public int Depth { get; set; } 
        
    }
}
