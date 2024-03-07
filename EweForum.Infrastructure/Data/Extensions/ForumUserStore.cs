using EweForum.Data;
using EweForum.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EweForum.Infrastructure.Data.Extensions
{
    public class ForumUserStore : UserStore<ForumUser>
    {
        public ForumUserStore(EweForumContext context, IdentityErrorDescriber describer = null) : base(context, describer)
        {
        }
    }
}
