
using EweForum.Data;
using EweForum.Infrastructure.Data.Models;
using EweForum.Models;
using EweForum.Utilites.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace EweForum.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        private readonly EweForumContext _context;

        public AdminController(EweForumContext context)
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
                UserCount = t.JoinedTopics.Count()
            }).ToListAsync();
            var paginationModel = new PaginationModel<TopicViewModel>
            {
                CurrentPageIndex = 1,
                Items = allTopics,
                PageIndex = 1,
                PageCount = topicCount / 5,
                PageSize = 5,
            };
            TempData["pageSize"] = 5;
            return View(paginationModel);
        }

        [HttpPost]
        public async Task<IActionResult> ManageTopics(
            PaginationModel<TopicViewModel> topics,
            [FromQuery] int? page = null,
            [FromQuery] int? pageSize = null)
        {
           
            
            //TempData["sortingOrder"]


            if (page.HasValue && pageSize.HasValue)
            {
                int previousPageSize = (int) TempData["pageSize"];

                int pageToShow = previousPageSize == pageSize.Value ? page.Value : 1;

                TempData["pageSize"] = pageSize.Value;

                int topicCount = await _context.Topics.CountAsync();
                int numberOfTopicsToSkip = pageToShow > 1 ? pageSize.Value * (pageToShow-1) : pageSize.Value;
                List<TopicViewModel> allTopics = null;
                if(topics.SearchTerm != null && topics.SearchTerm!="") {

                     allTopics = await _context.Topics
                    .Include(t => t.JoinedTopics)
                    .Where(t => t.Title.Contains(topics.SearchTerm, StringComparison.OrdinalIgnoreCase) ||
                                t.Description.Contains(topics.SearchTerm, StringComparison.OrdinalIgnoreCase))
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
                        UserCount = t.JoinedTopics.Count()
                    }).ToListAsync();
                }
                else
                {
                 allTopics =  await _context.Topics
                    .Include(t => t.JoinedTopics)
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
                        UserCount = t.JoinedTopics.Count()
                    }).ToListAsync();
                }
             
                var paginationModel = new PaginationModel<TopicViewModel>
                {
                    CurrentPageIndex = pageToShow,
                    Items = allTopics,
                    PageIndex = pageToShow,
                    PageCount = topicCount / pageSize.Value,
                    PageSize = pageSize.Value,
                    SearchTerm = topics.SearchTerm
                };

                return View(paginationModel);
            }
            return View(topics);
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
