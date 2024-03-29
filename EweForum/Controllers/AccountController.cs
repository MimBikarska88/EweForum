using EweForum.Data;
using EweForum.Infrastructure.Data.Models;
using EweForum.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging.Rules;
using System.Security.Claims;
using System.Text;

namespace EweForum.Controllers
{
    public class AccountController : BaseController
    {
        private readonly EweForumContext _context;
        private readonly SignInManager<ForumUser> _signInManager;
        private readonly UserManager<ForumUser> _userManager;
        private readonly IUserStore<ForumUser> _userStore;
        private readonly IUserEmailStore<ForumUser> _emailStore;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        

        private async Task<ICollection<CountryViewModel>> GetCountries()
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
                             ILogger<RegisterModel> logger,
                             IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
            _userStore = userStore;
            _emailStore = GetEmailStore();
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;

        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Register()
        {

            RegisterModel model = new RegisterModel();
            var countries = await GetCountries();
            model.Countries = countries;
            return View("Register", model);

        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterModel model)
        {


            if (ModelState.IsValid)
            {
                var user = CreateUser();
                user.CreatedOn = DateTime.Now;
                user.CountryId = model.CountryId;
                user.Email = model.Input.Email;
                user.UserName = model.Input.Username;
                

                await _userStore.SetUserNameAsync(user, model.Input.Username, CancellationToken.None);
                await _emailStore.SetEmailAsync(user, model.Input.Email, CancellationToken.None);
                var result = await _userManager.CreateAsync(user, model.Input.Password);

                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    await _userManager.AddToRoleAsync(user, "User");
                    return RedirectToAction("Login", "Account");

                }
                StringBuilder stringBuilder = new StringBuilder();
                foreach (var error in result.Errors)
                {
                    stringBuilder.AppendLine(error.Description);
                }
                model.ErrorMessage = stringBuilder.ToString();
            }

            // If we got this far, something failed, redisplay form
            var countries = await GetCountries();
            model.Countries = countries;
            return View("Register", model);
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
        [AllowAnonymous]
        public async Task<IActionResult> Login()
        {
            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);
            LoginModel model = new();
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginModel model)
        {


            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(model.Input.Username, model.Input.Password, true, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User logged in.");

                    
                    
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    model.ErrorMessage = "Invalid login attempt.";
                }
            }
            
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> ChangePassword()
        {
            if(User.Identity == null || !User.Identity.IsAuthenticated)
            {
                return Unauthorized();
            }
            var user = await _userManager.GetUserAsync(User);
            var hasPassword = await _userManager.HasPasswordAsync(user);
            if (!hasPassword)
            {
                return BadRequest("No password update is possible at the moment");
            }

            return View(new ChangePasswordModel());
        }
        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if(User.Identity==null || !User.Identity.IsAuthenticated)
            {
                return Unauthorized();
            }
            var user = await _userManager.GetUserAsync(User);
            var changePasswordResult = await _userManager.ChangePasswordAsync(user,model.Input.OldPassword, model.Input.NewPassword);
            if (!changePasswordResult.Succeeded)
            {
                StringBuilder stringBuilder = new StringBuilder();
                foreach (var error in changePasswordResult.Errors)
                {
                    stringBuilder.AppendLine(error.Description);
                }
                model.ErrorMessage = stringBuilder.ToString();
                return View(model);
            }

            await _signInManager.RefreshSignInAsync(user);
            _logger.LogInformation("User changed their password successfully.");
            var success = "Your password has been changed.";

            return View(new ChangePasswordModel { SuccessMessage = success });
        }

        [HttpPost]
        public async Task<JsonResult> Logout()
        {
            try
            {
                await _signInManager.SignOutAsync();
                _logger.LogInformation("Successfull logout");
                return Json(new { Success = true });
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return Json(new { Success = false });
            }

        }

       
        [HttpGet]
        public async Task<IActionResult> Edit()
        {
            if (User.Identity == null || !User.Identity.IsAuthenticated)
            {
                return Unauthorized();
            }
            string userId = GetUserId();
            var user = await _context.Users.OfType<ForumUser>()
                .Include(u => u.Country)
                .Include(u => u.CreatedTopics)
                .Include(u => u.JoinedTopics)
                .Include(u => u.ForumUsersFilesAttachments).ThenInclude(f => f.FileAttachment)
                .FirstOrDefaultAsync(u => u.Id == userId);
            if (user == null)
            {
                return BadRequest();
            }
            var avatarPath = user.ForumUsersFilesAttachments
                .OrderByDescending(fa => fa.FileAttachment.UploadedOn)
                .FirstOrDefault()
                ?.FileAttachment.Path;
          
            var filename = Path.GetFileName(avatarPath);

            var model = new ForumUserEditViewModel
            {
                Email = user.Email,
                ActiveSince = user.CreatedOn.ToShortDateString(),
                AvatarName = filename,
                PersonalInfo = user.PersonalInfo,
                PostsNumber = user.Posts.Count(),
                JoinedTopicsNumber = user.JoinedTopics.Count(),
                CreatedTopicsNumber = user.CreatedTopics.Count(),
                Username = user.UserName

            };
            return View(model);
        }
        [HttpPost]
        
        public async Task<IActionResult> Edit(ForumUserEditViewModel model)
        {
            
            if (!ModelState.IsValid)
            { 
                
               return View(model);   
            }
            if(User.Identity==null || !User.Identity.IsAuthenticated) {
                return Unauthorized();
            }
            var user = await _userManager.GetUserAsync(User);
            if (user.UserName == model.Username && User.Identity.IsAuthenticated)
            {
               
                user.PersonalInfo = model.PersonalInfo;
                user.Email = model.Email;
                if(model.Avatar != null)
                {
                    var currentAvatar = _context.ForumUsersAttachments
                        .Include(fa => fa.ForumUser)
                        .Where(fa => fa.ForumUserId == GetUserId())
                        .OrderByDescending(fa => fa.FileAttachment.UploadedOn)
                        .FirstOrDefault();
                    // remove is current avatar prop
                    var path = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                       
                    }
                    var fileName = string.Format(@"{0}{1}{2}", model.Avatar.FileName, DateTime.Now.Ticks, Path.GetExtension(model.Avatar.FileName));
                    var fullPath = Path.Combine(path, fileName);
                    using (FileStream fileStream = new (fullPath, FileMode.Create, FileAccess.ReadWrite))
                    {
                        await model.Avatar.CopyToAsync(fileStream);
                    }
                    var FileAttachment = new FileAttachment
                    {
                        Name = model.Avatar.Name,
                        Path = fullPath,
                        UploadedOn = DateTime.Now
                    };

                    await _context.ForumUsersAttachments.AddAsync(new ForumUserAttachment
                    {
                        
                        FileAttachment = FileAttachment,
                        ForumUser = user
                    });
                    model.AvatarName = fileName;
                   
                }
                var result = await _context.SaveChangesAsync();
                
                return View(model);
                    
            }
            
            
            return View(model);
        }
    }
}
