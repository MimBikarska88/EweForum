using EweForum.Data;
using EweForum.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EweForum.Controllers
{
    public class UsersController : BaseController
    {
        private readonly EweForumContext _context;
        public UsersController(EweForumContext context)
        {
            this._context = context;
        }
        [HttpPost]
        public async Task<IActionResult> ChangeActivity(string Username, string Email, bool IsActive)
        {
            var user = await _context.Users
                .OfType<ForumUser>()
                .Where(u => u.Email == Email && u.UserName == Username)
                .FirstOrDefaultAsync();
            if (user == null)
            {
                user.IsActive = IsActive;
            }
            else
            {
                return BadRequest();
            }
            await _context.SaveChangesAsync();

            // have to fix
            TempData["SuccessMessage"] = $"User {Username}'s activity was updated";
            return RedirectToAction("ManageTopics", "Topic");
        }
    }
}
