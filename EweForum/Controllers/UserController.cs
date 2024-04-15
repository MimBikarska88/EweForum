using EweForum.Data;
using EweForum.Infrastructure.Data.Models;
using EweForum.Models;
using EweForum.Utilites.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;

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

        [HttpGet]

        
        public async Task<IActionResult> ManageUsers ([FromQuery] int page, [FromQuery]  int pageSize, [FromQuery]  int sort , [FromQuery] string searchTerm)
        {
            if (!User.IsInRole("Admin"))
            {
                return Unauthorized();
            }

           
            int pagesToSkip = page-1;            
            int sortingOrder = 0; // none
            int size = 0;
            if(pageSize == 0)
            {
                size = 5;
            }
            string search = null; // none
            int totalPages = 0;

            if (TempData["userPageSize"] == null)
            {
                TempData["userPageSize"] = 5;
                size = 5;
            }
            else
            {
                int previousPageSize = (int)TempData["userPageSize"];
                if(previousPageSize == pageSize)
                {
                    size = pageSize;
                }
                else
                {
                    size = pageSize;
                    pagesToSkip = 0;
                   

                }
                TempData["userPageSize"] = pageSize;
            }
            if (TempData["userSearchTerm"] == null)
            {
                TempData["userSearchTerm"] = string.Empty;
                search = string.Empty;
            }
            else
            {
                string previousSearchTerm = TempData["userSearchTerm"].ToString();
                
                if(previousSearchTerm == "" && searchTerm == null || previousSearchTerm == searchTerm)
                {
                    search = searchTerm;
                }
                else
                {
                    search = searchTerm;
                    pagesToSkip = 0;
                   
                }
                TempData["userSearchTerm"] = searchTerm;
            }
            if (TempData["userOrder"] == null)
            {
                TempData["userOrder"] = 0;
                sortingOrder = 0;
            }
            else
            {
                int previousOrder = (int)TempData["userOrder"];
                if(previousOrder == sort)
                {
                    sortingOrder = sort;

                }
                else
                {
                    sortingOrder = sort;
                    pagesToSkip = 0;
                }

                TempData["userOrder"] = sortingOrder;
            }

            List<UserProfileViewModel> users = null;

            if(!Enum.IsDefined(typeof(SortingUserOrder), sortingOrder))
            {
                return BadRequest();
            }
            SortingUserOrder userOrder = (SortingUserOrder) sortingOrder;
            if(search!=null && search != string.Empty)
            {
                switch (userOrder)
                {
                    case SortingUserOrder.None:
                        {
                            totalPages = await _context.Users.OfType<ForumUser>()
                                .Include(u => u.JoinedTopics)
                                .Include(u => u.Posts)
                                .Include(u => u.PostsReplies)
                                .Include(u => u.Country)
                                .Where(u => u.UserName.Contains(search)
                                            || u.Email.Contains(search)
                                            || u.PersonalInfo.Contains(search)
                                            || u.Country.Name.Contains(search)
                                            || u.Country.Id.Contains(search)

                                ).CountAsync();
                            users = await _context.Users.OfType<ForumUser>()
                                .Include(u => u.JoinedTopics)
                                .Include(u => u.Posts)
                                .Include(u => u.PostsReplies)
                                .Include(u => u.Country)
                                .Where(u => u.UserName.Contains(search)
                                            || u.Email.Contains(search)
                                            || u.PersonalInfo.Contains(search)
                                            || u.Country.Name.Contains(search)
                                            || u.Country.Id.Contains(search)
                                
                                )
                                .Skip(pagesToSkip*size)
                                .Take(size)
                                .Select(u => new UserProfileViewModel{
                                    Username = u.UserName,
                                    Email = u.Email, 
                                    CreatedOn = u.CreatedOn.ToLongDateString(),
                                    IsActive = u.IsActive,
                                    JoinedTopics = u.JoinedTopics.Count(),
                                    PostsCount = u.Posts.Count(),
                                    RepliesCount = u.PostsReplies.Count(),
                                    Country = u.Country.Name
                                    })
                                .ToListAsync();
                    }break;
                    case SortingUserOrder.OrderByUsernameAlpabetically:
                        {
                           totalPages =  await _context.Users.OfType<ForumUser>()
                               .Include(u => u.JoinedTopics)
                               .Include(u => u.Posts)
                               .Include(u => u.PostsReplies)
                               .Include(u => u.Country)
                               .Where(u => u.UserName.Contains(search)
                                           || u.Email.Contains(search)
                                           || u.PersonalInfo.Contains(search)
                                           || u.Country.Name.Contains(search)
                                           || u.Country.Id.Contains(search)

                               ).CountAsync();

                            users = await _context.Users.OfType<ForumUser>()
                               .Include(u => u.JoinedTopics)
                               .Include(u => u.Posts)
                               .Include(u => u.PostsReplies)
                               .Include(u => u.Country)
                               .Where(u => u.UserName.Contains(search)
                                           || u.Email.Contains(search)
                                           || u.PersonalInfo.Contains(search)
                                           || u.Country.Name.Contains(search)
                                           || u.Country.Id.Contains(search)

                               )
                               .OrderBy(u => u.UserName)
                               .Skip(pagesToSkip*size)
                               .Take(size)
                               .Select(u => new UserProfileViewModel
                               {
                                   Username = u.UserName,
                                   Email = u.Email,
                                   CreatedOn = u.CreatedOn.ToLongDateString(),
                                   IsActive = u.IsActive,
                                   JoinedTopics = u.JoinedTopics.Count(),
                                   PostsCount = u.Posts.Count(),
                                   RepliesCount = u.PostsReplies.Count(),
                                   Country = u.Country.Name
                               })
                               .ToListAsync();
                        }break;
                    case SortingUserOrder.OrderByPosts:
                        {
                            totalPages = await _context.Users.OfType<ForumUser>()
                               .Include(u => u.JoinedTopics)
                               .Include(u => u.Posts)
                               .Include(u => u.PostsReplies)
                               .Include(u => u.Country)
                               .Where(u => u.UserName.Contains(search)
                                           || u.Email.Contains(search)
                                           || u.PersonalInfo.Contains(search)
                                           || u.Country.Name.Contains(search)
                                           || u.Country.Id.Contains(search)

                               )
                               .OrderByDescending(u => u.Posts.Count())
                               .CountAsync();
                            users = await _context.Users.OfType<ForumUser>()
                               .Include(u => u.JoinedTopics)
                               .Include(u => u.Posts)
                               .Include(u => u.PostsReplies)
                               .Include(u => u.Country)
                               .Where(u => u.UserName.Contains(search)
                                           || u.Email.Contains(search)
                                           || u.PersonalInfo.Contains(search)
                                           || u.Country.Name.Contains(search)
                                           || u.Country.Id.Contains(search)

                               )
                               .OrderByDescending(u => u.Posts.Count())
                               .Skip(pagesToSkip * size)
                               .Take(size)
                               .Select(u => new UserProfileViewModel
                               {
                                   Username = u.UserName,
                                   Email = u.Email,
                                   CreatedOn = u.CreatedOn.ToLongDateString(),
                                   IsActive = u.IsActive,
                                   JoinedTopics = u.JoinedTopics.Count(),
                                   PostsCount = u.Posts.Count(),
                                   RepliesCount = u.PostsReplies.Count(),
                                   Country = u.Country.Name
                               })
                               .ToListAsync();
                        }
                        break;
                    case SortingUserOrder.OrderByCommentsCount:
                        {
                            totalPages = await _context.Users.OfType<ForumUser>()
                               .Include(u => u.JoinedTopics)
                               .Include(u => u.Posts)
                               .Include(u => u.PostsReplies)
                               .Include(u => u.Country)
                               .Where(u => u.UserName.Contains(search)
                                           || u.Email.Contains(search)
                                           || u.PersonalInfo.Contains(search)
                                           || u.Country.Name.Contains(search)
                                           || u.Country.Id.Contains(search)

                               )
                               .OrderByDescending(u => u.PostsReplies.Count())
                               .CountAsync();

                            users = await _context.Users.OfType<ForumUser>()
                               .Include(u => u.JoinedTopics)
                               .Include(u => u.Posts)
                               .Include(u => u.PostsReplies)
                               .Include(u => u.Country)
                               .Where(u => u.UserName.Contains(search)
                                           || u.Email.Contains(search)
                                           || u.PersonalInfo.Contains(search)
                                           || u.Country.Name.Contains(search)
                                           || u.Country.Id.Contains(search)

                               )
                               .OrderByDescending(u => u.PostsReplies.Count())
                               .Skip(pagesToSkip * size)
                               .Take(size)
                               .Select(u => new UserProfileViewModel
                               {
                                   Username = u.UserName,
                                   Email = u.Email,
                                   CreatedOn = u.CreatedOn.ToLongDateString(),
                                   IsActive = u.IsActive,
                                   JoinedTopics = u.JoinedTopics.Count(),
                                   PostsCount = u.Posts.Count(),
                                   RepliesCount = u.PostsReplies.Count(),
                                   Country = u.Country.Name
                               })
                               .ToListAsync();
                        }
                        break;
                    case SortingUserOrder.OrderByEmailAlphabetically:
                        {
                            totalPages = await _context.Users.OfType<ForumUser>()
                               .Include(u => u.JoinedTopics)
                               .Include(u => u.Posts)
                               .Include(u => u.PostsReplies)
                               .Include(u => u.Country)
                               .Where(u => u.UserName.Contains(search)
                                           || u.Email.Contains(search)
                                           || u.PersonalInfo.Contains(search)
                                           || u.Country.Name.Contains(search)
                                           || u.Country.Id.Contains(search)

                               )
                               .OrderBy(u => u.UserName)
                               .CountAsync();
                            users = await _context.Users.OfType<ForumUser>()
                               .Include(u => u.JoinedTopics)
                               .Include(u => u.Posts)
                               .Include(u => u.PostsReplies)
                               .Include(u => u.Country)
                               .Where(u => u.UserName.Contains(search)
                                           || u.Email.Contains(search)
                                           || u.PersonalInfo.Contains(search)
                                           || u.Country.Name.Contains(search)
                                           || u.Country.Id.Contains(search)

                               )
                               .OrderBy(u => u.UserName)
                               .Skip(pagesToSkip * size)
                               .Take(size)
                               .Select(u => new UserProfileViewModel
                               {
                                   Username = u.UserName,
                                   Email = u.Email,
                                   CreatedOn = u.CreatedOn.ToLongDateString(),
                                   IsActive = u.IsActive,
                                   JoinedTopics = u.JoinedTopics.Count(),
                                   PostsCount = u.Posts.Count(),
                                   RepliesCount = u.PostsReplies.Count(),
                                   Country = u.Country.Name
                               })
                               .ToListAsync();
                        }break;

                    case SortingUserOrder.OrderByJoinedGroups:
                        {
                            totalPages = await _context.Users.OfType<ForumUser>()
                               .Include(u => u.JoinedTopics)
                               .Include(u => u.Posts)
                               .Include(u => u.PostsReplies)
                               .Include(u => u.Country)
                               .Where(u => u.UserName.Contains(search)
                                           || u.Email.Contains(search)
                                           || u.PersonalInfo.Contains(search)
                                           || u.Country.Name.Contains(search)
                                           || u.Country.Id.Contains(search)

                               ).OrderByDescending(u => u.JoinedTopics.Count())
                               .CountAsync();
                            users = await _context.Users.OfType<ForumUser>()
                               .Include(u => u.JoinedTopics)
                               .Include(u => u.Posts)
                               .Include(u => u.PostsReplies)
                               .Include(u => u.Country)
                               .Where(u => u.UserName.Contains(search)
                                           || u.Email.Contains(search)
                                           || u.PersonalInfo.Contains(search)
                                           || u.Country.Name.Contains(search)
                                           || u.Country.Id.Contains(search)

                               ).OrderByDescending(u => u.JoinedTopics.Count())
                               .Skip(pagesToSkip * size)
                               .Take(size)
                               .Select(u => new UserProfileViewModel
                               {
                                   Username = u.UserName,
                                   Email = u.Email,
                                   CreatedOn = u.CreatedOn.ToLongDateString(),
                                   IsActive = u.IsActive,
                                   JoinedTopics = u.JoinedTopics.Count(),
                                   PostsCount = u.Posts.Count(),
                                   RepliesCount = u.PostsReplies.Count(),
                                   Country = u.Country.Name
                               })
                               .ToListAsync();
                        }
                        break;

                }
            }
            else
            {
                totalPages = await _context.Users.OfType<ForumUser>()
                               .CountAsync();
                switch (userOrder)
                {
                    case SortingUserOrder.None:
                        {
                           
                                
                            users = await _context.Users.OfType<ForumUser>()
                                .Include(u => u.JoinedTopics)
                                .Include(u => u.Posts)
                                .Include(u => u.PostsReplies)
                                .Include(u => u.Country)
                                .Skip(pagesToSkip * size)
                                .Take(size)
                                .Select(u => new UserProfileViewModel
                                {
                                    Username = u.UserName,
                                    Email = u.Email,
                                    CreatedOn = u.CreatedOn.ToLongDateString(),
                                    IsActive = u.IsActive,
                                    JoinedTopics = u.JoinedTopics.Count(),
                                    PostsCount = u.Posts.Count(),
                                    RepliesCount = u.PostsReplies.Count(),
                                    Country = u.Country.Name
                                })
                                .ToListAsync();
                        }
                        break;
                    case SortingUserOrder.OrderByUsernameAlpabetically:
                        {
                            users = await _context.Users.OfType<ForumUser>()
                               .Include(u => u.JoinedTopics)
                               .Include(u => u.Posts)
                               .Include(u => u.PostsReplies)
                               .Include(u => u.Country)
                               .OrderBy(u => u.UserName)
                               .Skip(pagesToSkip * size)
                               .Take(size)
                               .Select(u => new UserProfileViewModel
                               {
                                   Username = u.UserName,
                                   Email = u.Email,
                                   CreatedOn = u.CreatedOn.ToLongDateString(),
                                   IsActive = u.IsActive,
                                   JoinedTopics = u.JoinedTopics.Count(),
                                   PostsCount = u.Posts.Count(),
                                   RepliesCount = u.PostsReplies.Count(),
                                   Country = u.Country.Name
                               })
                               .ToListAsync();
                        }
                        break;
                    case SortingUserOrder.OrderByPosts:
                        {
                            users = await _context.Users.OfType<ForumUser>()
                               .Include(u => u.JoinedTopics)
                               .Include(u => u.Posts)
                               .Include(u => u.PostsReplies)
                               .Include(u => u.Country)
                               .OrderByDescending(u => u.Posts.Count())
                               .Skip(pagesToSkip * size)
                               .Take(size)
                               .Select(u => new UserProfileViewModel
                               {
                                   Username = u.UserName,
                                   Email = u.Email,
                                   CreatedOn = u.CreatedOn.ToLongDateString(),
                                   IsActive = u.IsActive,
                                   JoinedTopics = u.JoinedTopics.Count(),
                                   PostsCount = u.Posts.Count(),
                                   RepliesCount = u.PostsReplies.Count(),
                                   Country = u.Country.Name
                               })
                               .ToListAsync();
                        }
                        break;
                    case SortingUserOrder.OrderByCommentsCount:
                        {
                            users = await _context.Users.OfType<ForumUser>()
                               .Include(u => u.JoinedTopics)
                               .Include(u => u.Posts)
                               .Include(u => u.PostsReplies)
                               .Include(u => u.Country)
                               .OrderByDescending(u => u.PostsReplies.Count())
                               .Skip(pagesToSkip * size)
                               .Take(size)
                               .Select(u => new UserProfileViewModel
                               {
                                   Username = u.UserName,
                                   Email = u.Email,
                                   CreatedOn = u.CreatedOn.ToLongDateString(),
                                   IsActive = u.IsActive,
                                   JoinedTopics = u.JoinedTopics.Count(),
                                   PostsCount = u.Posts.Count(),
                                   RepliesCount = u.PostsReplies.Count(),
                                   Country = u.Country.Name
                               })
                               .ToListAsync();
                        }
                        break;
                    case SortingUserOrder.OrderByEmailAlphabetically:
                        {
                            users = await _context.Users.OfType<ForumUser>()
                               .Include(u => u.JoinedTopics)
                               .Include(u => u.Posts)
                               .Include(u => u.PostsReplies)
                               .Include(u => u.Country)
                               .OrderBy(u => u.UserName)
                               .Skip(pagesToSkip * size)
                               .Take(size)
                               .Select(u => new UserProfileViewModel
                               {
                                   Username = u.UserName,
                                   Email = u.Email,
                                   CreatedOn = u.CreatedOn.ToLongDateString(),
                                   IsActive = u.IsActive,
                                   JoinedTopics = u.JoinedTopics.Count(),
                                   PostsCount = u.Posts.Count(),
                                   RepliesCount = u.PostsReplies.Count(),
                                   Country = u.Country.Name
                               })
                               .ToListAsync();
                        }
                        break;

                    case SortingUserOrder.OrderByJoinedGroups:
                        {
                            users = await _context.Users.OfType<ForumUser>()
                               .Include(u => u.JoinedTopics)
                               .Include(u => u.Posts)
                               .Include(u => u.PostsReplies)
                               .Include(u => u.Country)
                               .OrderByDescending(u => u.JoinedTopics.Count())
                               .Skip(pagesToSkip * size)
                               .Take(size)
                               .Select(u => new UserProfileViewModel
                               {
                                   Username = u.UserName,
                                   Email = u.Email,
                                   CreatedOn = u.CreatedOn.ToLongDateString(),
                                   IsActive = u.IsActive,
                                   JoinedTopics = u.JoinedTopics.Count(),
                                   PostsCount = u.Posts.Count(),
                                   RepliesCount = u.PostsReplies.Count(),
                                   Country = u.Country.Name
                               })
                               .ToListAsync();
                        }
                        break;

                }
            }

            var pages = totalPages / size;
            if(totalPages%size > 0)
            {
                pages++;
            }
            PaginationModel<UserProfileViewModel> model = new PaginationModel<UserProfileViewModel>()
            {
                PageCount = pages ,
                PageSize = size,
                CurrentPageIndex = pagesToSkip+1,
                PageIndex = pagesToSkip+1,
                Items = users,
                Order = (int) sortingOrder,
                SearchTerm = search

            };

          
            return View(model);
        }
    }
}
