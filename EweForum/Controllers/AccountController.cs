﻿using EweForum.Data;
using EweForum.Infrastructure.Data.Extensions;
using EweForum.Infrastructure.Data.Models;
using EweForum.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace EweForum.Controllers
{
    public class AccountController : Controller
    {
        private readonly EweForumContext _context;
        private readonly SignInManager<ForumUser> _signInManager;
        private readonly UserManager<ForumUser> _userManager;
        private readonly IUserStore<ForumUser> _userStore;
        private readonly IUserEmailStore<ForumUser> _emailStore;
        private readonly ILogger<RegisterModel> _logger;

        private async Task<ICollection<CountryViewModel>>GetCountries()
        {
            var result = await _context.Countries.AsNoTracking().Select(c => new CountryViewModel
            {
                Name = c.Name,
                Id = c.Id,
            }).ToListAsync();
            return result;
        }
        public AccountController(EweForumContext context,
                             UserManager<ForumUser> userManager,
                             IUserStore<ForumUser> userStore,
                             SignInManager<ForumUser> signInManager,
                             ILogger<RegisterModel>logger)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager; 
            _userStore = userStore;
            _emailStore = GetEmailStore();
            _logger = logger;

        }
       
        [HttpGet]
        public async Task<IActionResult> Register( [FromQuery] string returnUrl = null)
        {

            RegisterModel model = new RegisterModel();
            model.Countries = await GetCountries();
            model.ReturnUrl = returnUrl;
            return View("Register", model);

        }

        [HttpPost]
        public async Task<IActionResult> Register (RegisterModel model, string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            if (ModelState.IsValid)
            {
                var user = CreateUser();

                await _userStore.SetUserNameAsync(user, model.Input.Email, CancellationToken.None);
                await _emailStore.SetEmailAsync(user, model.Input.Email, CancellationToken.None);
                var result = await _userManager.CreateAsync(user, model.Input.Password);

                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return LocalRedirect(returnUrl);

                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return View("Register");
        }

        private ForumUser CreateUser()
        {
            try
            {
                return Activator.CreateInstance<ForumUser>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(ForumUser)}'. " +
                    $"Ensure that '{nameof(ForumUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }

        private IUserEmailStore<ForumUser> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<ForumUser>)_userStore;
        }
        [HttpGet]
        public async Task<IActionResult> Login(string returnUrl = null)
        {

            returnUrl ??= Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);
            LoginModel loginModel = new LoginModel();
            loginModel.ReturnUrl = returnUrl;
            return View("Login", loginModel);
        }

        [HttpPost]
        public async Task<IActionResult> OnPostAsync(LoginModel model, string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");



            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(model.Input.Email, model.Input.Password, true, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User logged in.");
                    return RedirectToAction("Index", "Home");   
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return RedirectToAction("Login", "Account");
                }
            }

            // If we got this far, something failed, redisplay form
            return RedirectToAction("Login", "Account");
        }
    }
}