namespace EweForum.Models
{
    public class ShortUserEditViewModel
    {
        public string UserId { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string ProfilePicturePath = string.Empty;

        public string PersonalInfo { get; set; } = string.Empty;

        public bool IsActive { get; set; }
    }
}
