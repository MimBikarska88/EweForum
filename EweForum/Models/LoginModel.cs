using EweForum.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

namespace EweForum.Models
{
    public class LoginModel
    {

            public InputModel Input { get; set; } = null!;

            public string ReturnUrl { get; set; } = string.Empty;
            [TempData]
            public string ErrorMessage { get; set; } = string.Empty;
     }
}
