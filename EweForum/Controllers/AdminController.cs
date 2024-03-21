
using EweForum.Data;
using EweForum.Infrastructure.Data.Models;
using EweForum.Models;
using EweForum.Utilites.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
                PageSize = 5
            };
            return View(paginationModel);
        }

        [HttpPost]
        public async Task<IActionResult> ManageTopics(
            PaginationModel<TopicViewModel> topics,
            [FromQuery] string? searchTerm = null,
            [FromQuery] SortingOrder? order = null ,
            [FromQuery] int? page = null,
            [FromQuery] int? displayRows = null)
        {

            if (page != null)
            {
                int topicCount = await _context.Topics.CountAsync();
                int numberOfTopicsToSkip = topics.PageSize * page.Value;
                var allTopics = await _context.Topics.Include(t => t.JoinedTopics).Skip(numberOfTopicsToSkip)
                .Take(topics.PageSize)
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
                    CurrentPageIndex = page.Value,
                    Items = allTopics,
                    PageIndex = page.Value,
                    PageCount = topicCount / topics.PageSize,
                    PageSize = topics.PageSize,
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
