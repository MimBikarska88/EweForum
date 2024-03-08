using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace EweForum.Models
{
    public class LoginInputModel
    {
        [Required]
        [EmailAddress]

        public string Email { get; set; } = string.Empty;


        [Required]
        [PasswordPropertyText]

        public string Password { get; set; } = string.Empty;
    }
}
