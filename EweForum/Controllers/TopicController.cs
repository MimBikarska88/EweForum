
using EweForum.Data;
using EweForum.Infrastructure.Data.Datasets.JsObjects;
using EweForum.Infrastructure.Data.Models;
using EweForum.Models;
using EweForum.Utilites.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Printing;
using System.Text;

namespace EweForum.Controllers
{
    
    public class TopicController : BaseController
    {
        private readonly EweForumContext _context;

        public TopicController(EweForumContext context)
        {
            _context = context;
        }

        [HttpGet("ManageTopics")]
        public async Task<IActionResult> ManageTopics()
        {
            var topicCount = await _context.Topics.CountAsync();
            var allTopics = await _context.Topics.Include(t => t.JoinedTopics).Take(5)
            .Select(t => new TopicViewModel
            {
                Title = t.Title,
                Id = t.Id,
                CreatedOn = t.CreatedOn,
                ModifiedOn = t.UpdatedOn,
                Description = t.Description,
                IsActive = t.IsActive,
                UserCount = t.JoinedTopics.Count(),
                IsCurrentUserJoined = t.JoinedTopics.Any(t => t.ForumUserId==GetUserId())
            }).ToListAsync();
            var paginationModel = new PaginationModel<TopicViewModel>
            {
                CurrentPageIndex = 1,
                Items = allTopics,
                PageIndex = 1,
                PageCount = topicCount / 5,
                PageSize = 5,
                TopicsInfo = await GetTopicInfo()
            };
            TempData["pageSize"] = 5;
            TempData["order"] = 0;
            TempData["searchTerm"] = string.Empty;
            return View(paginationModel);
        }

        [HttpPost]
        public async Task<IActionResult> ManageTopics(
            PaginationModel<TopicViewModel> model,
            [FromQuery] int? page = null,
            [FromQuery] int? pageSize = null
            )
        {


            if (page.HasValue && pageSize.HasValue)
            {
                int previousPageSize = (int)TempData["pageSize"];

                string previousSearchTerm = (string) TempData["searchTerm"];

                int previousOrder = (int)TempData["order"];

                int pageToShow = (previousPageSize == pageSize.Value
                                   && previousSearchTerm == model.SearchTerm
                                   && previousOrder == model.Order
                                   ) ? page.Value : 1;

                int topicCount = await _context.Topics.CountAsync();

                TempData["pageSize"] = pageSize.Value;

                TempData["order"] = model.Order;

                TempData["searchTerm"] = model.SearchTerm;



                // collect all topics

                List<Topic> all = await _context.Topics.Include(t => t.JoinedTopics).Select(t => new Topic
                {
                    UpdatedOn = t.UpdatedOn,
                    Id  = t.Id,
                    JoinedTopics = t.JoinedTopics.ToList(),
                    Description = t.Description,
                    Title = t.Title,
                    IsActive = t.IsActive,
                }).ToListAsync();

                if (model.SearchTerm != null && model.SearchTerm != "")
                {
                    all = all.Where(t => t.Description.Contains(model.SearchTerm) ||
                                          t.Title.Contains(model.SearchTerm)).ToList();
                    topicCount = all.Count();

                }
                if (model.Order != 0)
                {
                    if (!Enum.TryParse(typeof(SortOrder), model.Order.ToString(), out var orderType))
                    {
                        return BadRequest();
                    }
                    all = Sort((SortingOrder)orderType, all);
                }

                int numberOfTopicsToSkip = pageToShow > 1 ? pageSize.Value * (pageToShow - 1) : pageSize.Value;

                if (page.Value == 1 || pageToShow == 1)
                {
                    numberOfTopicsToSkip = 0;
                }


                List<TopicViewModel> topicViewModels = all
                    .Skip(numberOfTopicsToSkip)
                    .Take(pageSize.Value)
                    .Select(t => new TopicViewModel
                    {
                        Title = t.Title,
                        Id = t.Id,
                        CreatedOn = t.CreatedOn,
                        ModifiedOn = t.UpdatedOn,
                        Description = t.Description,
                        IsActive = t.IsActive,
                        UserCount = t.JoinedTopics.Count(),
                        IsCurrentUserJoined = t.JoinedTopics.Any(t => t.ForumUserId == GetUserId())
                    }).ToList();
                var topicsInfoModel = new TopicsInfoViewModel
                {
                    TopicsCount = await _context.Topics.CountAsync(),
                    UserCount = await _context.Users.CountAsync(),
                    InactiveTopicsCount = await _context.Topics.Where(t => !t.IsActive).CountAsync(),
                    ActiveTopicsCount = await _context.Topics.Where(t => t.IsActive).CountAsync(),
                    NewTopicsCount = await _context.Topics.Where(t => t.CreatedOn.Month == DateTime.Now.Month).CountAsync(),
                };
                var paginationModel = new PaginationModel<TopicViewModel>
                {
                    CurrentPageIndex = pageToShow,
                    Items = topicViewModels,
                    PageIndex = pageToShow,
                    PageCount = topicCount / pageSize.Value,
                    PageSize = pageSize.Value,
                    SearchTerm = model.SearchTerm,
                    TopicsInfo = await GetTopicInfo(),
                };

                return View(paginationModel);

            }
            return View(model);

        }

        private async Task<TopicsInfoViewModel> GetTopicInfo()
        {
            return new TopicsInfoViewModel
            {
                TopicsCount = await _context.Topics.CountAsync(),
                UserCount = await _context.Users.CountAsync(),
                InactiveTopicsCount = await _context.Topics.Where(t => !t.IsActive).CountAsync(),
                ActiveTopicsCount = await _context.Topics.Where(t => t.IsActive).CountAsync(),
                NewTopicsCount = await _context.Topics.Where(t => t.CreatedOn.Month == DateTime.Now.Month).CountAsync(),
            };
        }
        [HttpGet]
        public IActionResult Create(){
            if (User.Identity != null && User.Identity.IsAuthenticated && User.IsInRole("Admin"))
            {
                var model = new CreateTopicViewModel();
                model.UserId = GetUserId();
                return View(model);
            }
            return Unauthorized();
           
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateTopicViewModel model)
        {
            if(User.Identity == null || !User.Identity.IsAuthenticated   || !User.IsInRole("Admin"))
            {
                return Unauthorized();
            }
            
            if(!ModelState.IsValid)
            {
                StringBuilder errorList = new StringBuilder();
 
                foreach(var state in ModelState.Values)
                {
                    foreach(var error in state.Errors)
                    {
                        errorList.AppendLine(error.ErrorMessage.ToString());
                    }
                }
                model.Message.ErrorMessage = errorList.ToString();
                return View(model);
            }
            if(await _context.Topics.AnyAsync(t => t.Title == model.Title)){
                model.Message = new MessageModel();
                model.Message.ErrorMessage = "Please, choose a non existing name for the forum topic";
                return View(model);
            }
            await _context.Topics.AddAsync(new Topic
            {
                Title = model.Title,
                Description = model.Description,
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now,
                IsActive = false,
                ForumUserId = GetUserId()
            });

            var success = await _context.SaveChangesAsync();
            if (success == 0)
            {
                model = new CreateTopicViewModel();
                model.Message.ErrorMessage = "Something went wrong, please try again";
            }
            TempData["SuccessMessage"] = "Topic created successfully!";
            return RedirectToAction("ManageTopics");
            
        }
        private List<Topic> Sort(SortingOrder? order,List<Topic>topics)
        {
            if (order == null) return topics;
            switch (order)
            {
                case SortingOrder.Alphabetically: topics = topics.OrderBy(t => t.Title).ToList(); break;
                case SortingOrder.DateDesc: topics = topics.OrderByDescending(t => t.CreatedOn).ToList(); break;
                case SortingOrder.DateAsc: topics = topics.OrderBy(t => t.CreatedOn).ToList(); break;
                case SortingOrder.PopularityAsc: topics = topics.OrderBy(t => t.JoinedTopics.Count()).ToList(); break;
                case SortingOrder.PopularityDesc: topics = topics.OrderByDescending(t => t.JoinedTopics.Count()).ToList(); break;
            }
            return topics;
        }
        private List<JoinedTopic>SortJoinedTopics(SortingUserOrder order, List<JoinedTopic> topics)
        {
            if(order == null) return topics;
            switch (order)
            {
                case SortingUserOrder.OrderByUsernameAlpabetically: topics = topics.OrderBy(t => t.ForumUser.UserName).ToList(); break;
                case SortingUserOrder.OrderByEmailAlphabetically: topics = topics.OrderBy(t => t.ForumUser.Email).ToList(); break;  
            }
            return topics;
        }

        [HttpGet]
        public async Task<IActionResult> Edit([FromQuery] int topicId)
        {
            TempData["pageSize"] = 5;
            TempData["order"] = 0;

      

            var topic = await _context.Topics
                .Include(t => t.JoinedTopics)
                .ThenInclude(jt => jt.ForumUser)
                .ThenInclude(jt => jt.ForumUsersFilesAttachments)
                .ThenInclude(fa => fa.FileAttachment)
                .Where(t => t.Id == topicId)
                .Select(t => new Topic
                {
                    Id = t.Id,
                    JoinedTopics = t.JoinedTopics.Select(jt => new JoinedTopic
                    {
                        ForumUser = jt.ForumUser,
                    })
                    .ToList(),
                    Title = t.Title,
                    Description = t.Description,

                    
                })
                .FirstOrDefaultAsync();

            
            var editTopicModel = new EditTopicViewModel
            {
                UserId = GetUserId(),
                TopicId = topicId,
                IsActive = topic.IsActive,
                Description = topic.Description,
                Title = topic.Title,
                
            };
            // initial page count = 5
            var paginationModel = new PaginationModel<ShortUserEditViewModel>
            {
                PageCount = topic.JoinedTopics.Count() / 5,
                PageIndex = 1,
                CurrentPageIndex = 1,
                PageSize = 5,
                Items = topic.JoinedTopics.Select(jt => new ShortUserEditViewModel
                {
                    PersonalInfo = jt.ForumUser.PersonalInfo,
                    UserId = jt.ForumUserId,
                    ProfilePicturePath = jt.ForumUser
                    .ForumUsersFilesAttachments
                    .OrderByDescending(fa => fa.FileAttachment.UploadedOn)
                    .FirstOrDefault()
                    ?.FileAttachment.Name,
                    Email = jt.ForumUser.Email,
                    IsActive = jt.ForumUser.IsActive,
                    Username = jt.ForumUser.UserName,
                }).Take(5).ToList()
            };

            editTopicModel.PaginationModel = paginationModel;
      

            return View(editTopicModel);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(EditTopicViewModel model, [FromQuery] int? page , [FromQuery] int? pageSize)
        {
            if(page.HasValue && pageSize.HasValue)
            {
                int previousPageSize = (int)TempData["pageSize"];

                int previousOrder = (int)TempData["order"];

                int pageToShow = (previousPageSize == pageSize.Value
                                   && 
                                  previousOrder == model.PaginationModel.Order
                                  ) ? page.Value : 1;

                TempData["pageSize"] = pageSize.Value;
                TempData["order"] = model.PaginationModel.Order;

                var topic = await _context.Topics
                .Include(t => t.JoinedTopics)
                .ThenInclude(jt => jt.ForumUser)
                .ThenInclude(jt => jt.ForumUsersFilesAttachments)
                .ThenInclude(fa => fa.FileAttachment)
                .Where(t => t.Id == model.TopicId)
                .Select(t => new Topic
                {
                    Id = t.Id,
                    JoinedTopics = t.JoinedTopics.Select(jt => new JoinedTopic
                    {
                        ForumUser = jt.ForumUser,
                    }).ToList(),
                    Title = t.Title,
                    Description = t.Description,
                })
                .FirstOrDefaultAsync();

                int numberOfTopicsToSkip = pageToShow > 1 ? 
                    pageSize.Value * (pageToShow - 1) 
                    :
                    pageSize.Value;

                if (page.Value == 1 || pageToShow == 1)
                {
                    numberOfTopicsToSkip = 0;
                }

                var editTopicModel = new EditTopicViewModel
                {
                    UserId = GetUserId(),
                    TopicId = topic.Id,
                    IsActive = topic.IsActive,
                    Description = topic.Description,
                    Title = topic.Title,

                };
                int pageCount = topic.JoinedTopics.Count() / pageSize.Value;
                if(topic.JoinedTopics.Count() % pageSize.Value > 0)
                {
                    pageCount++;
                }
                var paginationModel = new PaginationModel<ShortUserEditViewModel>
                {
                    PageCount = pageCount,
                    PageIndex = pageToShow,
                    CurrentPageIndex = pageToShow,
                    PageSize = pageSize.Value,
                    
                };

                var items = topic.JoinedTopics.ToList();
                // PROCESS SORTING
             
                if(Enum.IsDefined(typeof(SortingUserOrder), model.PaginationModel.Order))
                {
                    SortingUserOrder order = (SortingUserOrder) Enum.Parse(typeof(SortingUserOrder), model.PaginationModel.Order.ToString());
                    items = SortJoinedTopics(order, items);
                }
                
                paginationModel.Items = items
                    .Skip(numberOfTopicsToSkip)
                    .Take(pageSize.Value)
                    .Select(jt => new ShortUserEditViewModel
                    {
                        PersonalInfo = jt.ForumUser.PersonalInfo,
                        UserId = jt.ForumUserId,
                        ProfilePicturePath = jt.ForumUser
                        .ForumUsersFilesAttachments
                        .OrderByDescending(fa => fa.FileAttachment.UploadedOn)
                        .Select(fa => fa.FileAttachment.Name)
                        .FirstOrDefault(), 
                        Email = jt.ForumUser.Email,
                        IsActive = jt.ForumUser.IsActive,
                        Username = jt.ForumUser.UserName,
                    }).ToList();

                TempData["pageSize"] = pageSize.Value;
                editTopicModel.PaginationModel = paginationModel;
                return View(editTopicModel);

            }
            else
            {
                var topic = await _context.Topics.FindAsync(model.TopicId);
                topic.UpdatedOn = DateTime.Now;
                topic.Title = model.Title;
                topic.Description = model.Description;
                topic.IsActive = model.IsActive;
                await _context.SaveChangesAsync();
                
            }
            return RedirectToAction("Edit", new { topicId = model.TopicId });
        }
    }
}
