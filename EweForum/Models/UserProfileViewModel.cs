using MessagePack;

namespace EweForum.Models
{
    public class UserProfileViewModel
    {
        public string Username { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string PersonalInfo { get; set; } = string.Empty;

        public string ProfilePicturePath { get; set; } = string.Empty;

        public bool IsActive { get; set; }  

        public int PostsCount { get; set; }
        
        public int JoinedTopics { get; set; }

        public int TopicsCount { get; set; }
        public int RepliesCount { get; set; }

        public string CreatedOn { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;

    }
}
