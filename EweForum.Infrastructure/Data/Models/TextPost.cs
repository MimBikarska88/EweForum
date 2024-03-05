using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EweForum.Infrastructure.Data.Models
{
    public class TextPost : Post
    {
        [Column(TypeName = "text")]
        public string Content { get; set; } = string.Empty;

    }
}
