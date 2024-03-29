
using EweForum.Data;
using EweForum.Infrastructure.Data.Datasets.JsObjects;
using EweForum.Infrastructure.Data.Models;
using EweForum.Models;
using EweForum.Utilites.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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


            //TempData["sortingOrder"]


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
    }
}
