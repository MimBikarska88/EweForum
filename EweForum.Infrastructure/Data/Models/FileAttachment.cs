using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EweForum.Infrastructure.Data.Models
{
    public class FileAttachment
    {
        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; } = string.Empty;

        public string Path { get; set; } = string.Empty;

        public DateTime UploadedOn { get; set; }

        public IEnumerable<ForumUserAttachment> ForumUsersFilesAttachments { get; set; } = new List<ForumUserAttachment>();
        public IEnumerable<PostAttachment> PostsAttachments { get; set; }  = new List<PostAttachment>();


    }
}
