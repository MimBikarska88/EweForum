using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EweForum.Infrastructure.Data.Models
{
    public class PostAttachment
    {
        public int PostId { get; set; }

        [ForeignKey(nameof(PostId))]
        public Post Post { get; set; } = null!;

        public int FileAttachmentId { get; set; }
        [ForeignKey(nameof(FileAttachmentId))]
        public FileAttachment FileAttachment { get; set; } = null!;
    }
}
