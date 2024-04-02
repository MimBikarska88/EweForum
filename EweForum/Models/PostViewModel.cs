using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EweForum.Models
{
    public class PostViewModel
    {
       
        public string Title { get; set; } = string.Empty;

        [Required]
        public int PostType { get; set; }

        public string Description { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;
        public string Start { get; set; } = null!;

        public string End { get; set; } = null!;

        public string VideoUrl { get; set; } = string.Empty;


        



    }
}
