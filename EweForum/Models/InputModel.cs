using System.ComponentModel.DataAnnotations;

namespace EweForum.Models
{
    public class InputModel
    {
     [Required]
     [DataType("email")]
     public string Email { get; set; } = string.Empty;


    [Required]
    [DataType("password")]
    public string Password { get; set; } = string.Empty;

    [Required]
    [DataType("password")]
    public string ConfirmPassword { get; set; } = string.Empty;

    [Required]
    public string CountryId { get; set; } = string.Empty;

    public List<CountryViewModel> Countries = new();

    }
}
