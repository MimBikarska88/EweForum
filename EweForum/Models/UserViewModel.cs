namespace EweForum.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;

        public string Email { get; set; }= string.Empty;

        public DateTime JoinedOn { get; set; }

        public string ProfilePicturePath { get; set; } = string.Empty;

        public bool IsActive { get; set; }


    }
}
