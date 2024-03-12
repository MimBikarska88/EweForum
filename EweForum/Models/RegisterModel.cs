// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading;
using System.Threading.Tasks;
using EweForum.Infrastructure.Data.Models;
using EweForum.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;

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
