
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

                List<Topic> all = await _context.Topics.ToListAsync();

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
                        UserCount = t.JoinedTopics.Count()
                    }).ToList();
                var paginationModel = new PaginationModel<TopicViewModel>
                {
                    CurrentPageIndex = pageToShow,
                    Items = topicViewModels,
                    PageIndex = pageToShow,
                    PageCount = topicCount / pageSize.Value,
                    PageSize = pageSize.Value,
                    SearchTerm = model.SearchTerm
                };

                return View(paginationModel);

















                /*

                int numberOfTopicsToSkip = pageToShow > 1 ? pageSize.Value * (pageToShow-1) : pageSize.Value;
                if(Enum.IsDefined(typeof(SortingOrder), topics.Order) || Enum.TryParse(typeof(SortingOrder), topics.Order.ToString(), out var sortingOrder))
                {
                    return BadRequest();
                }

                if(page.Value == 1 || pageToShow==1) {
                    numberOfTopicsToSkip = 0;
                }
                List<TopicViewModel> allTopics = null;
                List<Topic> rawTopics = await _context.Topics.Include(t => t.JoinedTopics).ToListAsync();


                if (topics.SearchTerm != null && topics.SearchTerm!="") {

                    rawTopics = rawTopics
                   .Where(t => t.Title.Contains(topics.SearchTerm, StringComparison.OrdinalIgnoreCase) ||
                               t.Description.Contains(topics.SearchTerm, StringComparison.OrdinalIgnoreCase)).ToList();
                    rawTopics = Sort((SortingOrder)sortingOrder, rawTopics);



                    allTopics = rawTopics.Skip(numberOfTopicsToSkip)
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
            } */

            }
            return View(model);

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
