using Microsoft.AspNetCore.Mvc;

namespace EweForum.Models
{
    public class ChangePasswordModel
    {

        public ChangePasswordInputModel Input { get; set; } = null!;

        
        public string SuccessMessage { get; set; } = string.Empty;

        public string ErrorMessage { get; set; } = string.Empty;
    }
}
