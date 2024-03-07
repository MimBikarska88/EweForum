using EweForum.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EweForum.Infrastructure.Data.Extensions
{
    public class ForumUserManager : UserManager<ForumUser>
    {

        public ForumUserManager(IUserStore<ForumUser> store,
            IOptions<IdentityOptions> optionsAccessor,
            IPasswordHasher<ForumUser> passwordHasher,
            IEnumerable<IUserValidator<ForumUser>> userValidators,
            IEnumerable<IPasswordValidator<ForumUser>> passwordValidators,
            ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors,
            IServiceProvider services, ILogger<UserManager<ForumUser>> logger) : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
        }
    }
}
