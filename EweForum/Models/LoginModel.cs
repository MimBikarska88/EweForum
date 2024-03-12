using EweForum.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

namespace EweForum.Models
{
    public class LoginModel
    {

            public LoginInputModel Input { get; set; } = null!;
            public string ErrorMessage { get; set; } = string.Empty;
           


    }
}
