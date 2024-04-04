using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EweForum.Models
{
    public class PostViewModel
    {
       
        public string Title { get; set; } = string.Empty;

        [Required]
        public int PostType { get; set; }

		public int Id { get; set; }

		public string EventDescription { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;
        public string Start { get; set; } = string.Empty;

		public string End { get; set; } = string.Empty;

        public string VideoUrl { get; set; } = string.Empty;
		public string VideoDescription { get; set; } = string.Empty;

        public string EventTitle { get;set; } = string.Empty;

        public string VideoTitle { get;set; } = string.Empty;

		public int TopicId { get; set; }

        public string Username { get; set; } = string.Empty;






	}
}
