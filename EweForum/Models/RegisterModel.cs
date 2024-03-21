// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable



namespace EweForum.Models
{
    public class RegisterModel
    {
       
        public InputModel Input { get; set; }
        public string ReturnUrl { get; set; }
    
        public string CountryId { get; set; }

        public string ErrorMessage { get; set; } = string.Empty;
        public ICollection<CountryViewModel> Countries { get; set; } = new List<CountryViewModel>();
    }
}
