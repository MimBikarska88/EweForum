using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;


namespace EweForum.Infrastructure.Data.Models
{
    public class ForumUserAttachment
    {
       
        public string ForumUserId { get; set; } = string.Empty;
        [ForeignKey(nameof(ForumUserId))]
        public ForumUser ForumUser { get; set; } = null!;

        public int FileAttachmentId { get; set; }
        [ForeignKey(nameof(FileAttachmentId))]
        public FileAttachment FileAttachment { get; set; } = null!;

       

    }
}
