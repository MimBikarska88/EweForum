using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace EweForum.Models
{
    public class LoginInputModel
    {
        [Required]
        [Display(Name = "Username")]

        public string Username { get; set; } = string.Empty;


        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]

        public string Password { get; set; } = string.Empty;
    }
}
