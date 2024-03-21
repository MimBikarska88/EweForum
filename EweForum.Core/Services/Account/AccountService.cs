using EweForum.Data;
using EweForum.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace EweForum.Core.Services.Account
{
    public class AccountService : IAccountService
    {
        private readonly EweForumContext _context;
        private readonly UserManager<ForumUser> _userManager;
        private readonly IUserStore<ForumUser> _userStore;
        private readonly IUserEmailStore<ForumUser> _emailStore;

        public AccountService(UserManager<ForumUser> userManager,
                             IUserStore<ForumUser> userStore,
                             EweForumContext context)
        {
            _context = context;
            _userManager = userManager;
            _userStore = userStore;
            _emailStore = GetEmailStore();
        }

        private IUserEmailStore<ForumUser> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<ForumUser>)_userStore;
        }
       

      
    }
}
