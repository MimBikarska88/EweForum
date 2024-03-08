﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EweForum.Models
{
    public class InputModel
    {
        [Required]
        [EmailAddress]

        public string Email { get; set; } = string.Empty;


        [Required]
        [PasswordPropertyText]

        public string Password { get; set; } = string.Empty;

        [Required]
        [PasswordPropertyText]

        public string ConfirmPassword { get; set; } = string.Empty;

    }
}
