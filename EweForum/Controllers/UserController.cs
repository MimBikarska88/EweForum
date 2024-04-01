using EweForum.Data;
using EweForum.Infrastructure.Data.Models;
using EweForum.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EweForum.Controllers
{
    public class UserController : BaseController
    {
        private readonly EweForumContext _context;
        public UserController(EweForumContext context)
        {
            this._context = context;
        }
        [HttpGet]
        public async Task<IActionResult> ViewProfile(string Username)
        {

            var user = await _context
                .Users.OfType<ForumUser>()
                .Include(u => u.JoinedTopics)
                .Include(u => u.Posts)
                .Include(u => u.ForumUsersFilesAttachments)
                .ThenInclude(f => f.FileAttachment)
                .Where(u => u.UserName.Equals(Username))
                .Select(u => new
                {
                    u.UserName,
                    u.Email,
                    u.PersonalInfo,
                    u.IsActive,
                    ProfilePicturePath = u.ForumUsersFilesAttachments
                    .OrderByDescending(f => f.FileAttachment.UploadedOn)
                    .Select(f => f.FileAttachment.Name)
                    .FirstOrDefault(),
                    PostsCount = u.Posts.Count(),
                    TopicsCount = u.JoinedTopics.Count(),
                    ActiveSince = u.CreatedOn,
                    Country = u.Country,
                })
                .FirstOrDefaultAsync();

            if (user != null)
            {
                var model = new UserProfileViewModel
                {
                    PostsCount = user.PostsCount,
                    TopicsCount = user.TopicsCount,
                    Username = user.UserName,
                    CreatedOn = user.ActiveSince.ToLongDateString(),
                    Email = user.Email,
                    IsActive = user.IsActive,
                    PersonalInfo = user.PersonalInfo,
                    Country = user?.Country?.Name,
                    ProfilePicturePath = user.ProfilePicturePath != null && user.ProfilePicturePath != ""
                    ?
                    user.ProfilePicturePath
                    : "incognito1.png"
                };
                return View(model);
            }
            else
            {
                return BadRequest();
            }

        }
        [HttpPost]
        public async Task<IActionResult> SetActivity(UserProfileViewModel model)
        {
            if (User.IsInRole("Admin") || User.Identity.Name.Equals(model.Username))
            {
                var user = await _context.Users
                    .OfType<ForumUser>()
                    .Where(u => u.UserName.Equals(model.Username))
                    .FirstOrDefaultAsync();
                if(user != null) {
                    user.IsActive = model.IsActive;
                    await _context.SaveChangesAsync();
                    return RedirectToAction("ViewProfile", new
                    {
                        Username = model.Username
                    });
                }
                else
                {
                    return BadRequest();
                }


            }
            else
            {
                return Unauthorized();
            }
           
           
        }
    }
}
