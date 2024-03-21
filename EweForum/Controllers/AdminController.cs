using EweForum.Core.Services.Topic;
using EweForum.Utilites.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EweForum.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        private readonly ITopicService _topics;

        public AdminController(ITopicService topics)
        {
            _topics = topics;
        }

        [HttpGet("ManageTopics")]
        public async Task<IActionResult> ManageTopics([FromQuery]string? searchTerm = null, [FromQuery] SortingOrder? order = null,[FromQuery] int topicsPerPage = 1)
        {
            return View();
        }
    }
}
