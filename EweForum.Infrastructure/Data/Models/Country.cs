using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EweForum.Infrastructure.Data.Models
{
    public class Country
    {
        [Key]

        public string Id { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public virtual IEnumerable<ForumUser> ForumUsers { get; set; } = new List<ForumUser>();
    }
}
