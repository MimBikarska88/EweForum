using EweForum.Models;
using Microsoft.AspNetCore.Mvc;

namespace EweForum.Controllers
{
    public class PostController : BaseController
    {
        public IActionResult Create(int topicId)
        {
            var postModel = new PostViewModel();
            return View(postModel);
        }
    }
}
