using System.ComponentModel.DataAnnotations;

namespace EweForum.Models
{
    public class CreateTopicViewModel
    {
        [Required]
        [Display(Name = "Forum topic Title")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "{0} should have length between {2} and {1} characters")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [Display(Name ="Forum topic description")]
        [StringLength(400, MinimumLength = 10, ErrorMessage = "{0} should have length between {2} and {1} characters")]
        public string Description { get; set; } = string.Empty;

        public MessageModel Message { get; set; } = new MessageModel();

        public string UserId { get; set; } = string.Empty;
    }
}
