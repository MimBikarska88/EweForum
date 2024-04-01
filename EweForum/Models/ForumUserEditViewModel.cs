using Microsoft.Extensions.Configuration.UserSecrets;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EweForum.Models
{
    public class ForumUserEditViewModel
    {
        [Required]
        
        public string PersonalInfo { get; set; } = string.Empty;

        public IFormFile? Avatar { get; set; }

        public string AvatarName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Username { get; set; } = string.Empty;
        public int PostsNumber { get; set; } 

        public int JoinedTopicsNumber { get; set; }

        public int CreatedTopicsNumber { get; set; }

        public string ActiveSince { get; set; } = String.Empty;

        
    }
}
