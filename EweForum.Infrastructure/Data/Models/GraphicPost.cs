using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EweForum.Infrastructure.Data.Models
{
    public class VideoPost : Post
    {
        public string VideoUrl { get; set; } = string.Empty;
    }
}
