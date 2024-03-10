using Microsoft.Extensions.Configuration.UserSecrets;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EweForum.Models
{
    public class ForumUserEditViewModel
    {
        [Column(TypeName = "text")]
        [Required(ErrorMessage = "Please, write a few things about yourself")]
        public string PersonalInfo { get; set; } = string.Empty;

        [Column(TypeName = "text")]
        [Required(ErrorMessage = "Please, write a few things about yourself")]
        public string AvatarPath { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
        public int PostsNumber { get; set; } 

        public int JoinedTopicsNumber { get; set; }

        public int CreatedTopicsNumber { get; set; }

        public string ActiveSince { get; set; } = String.Empty;
    }
}
