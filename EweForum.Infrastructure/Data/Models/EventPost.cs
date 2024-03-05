using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EweForum.Infrastructure.Data.Models
{
    public class EventPost : Post
    {
        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public string Cause { get; set; } = string.Empty;
    }
}
