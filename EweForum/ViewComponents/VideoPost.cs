using EweForum.Models;
using Microsoft.AspNetCore.Mvc;

namespace EweForum.ViewComponents
{
    public class VideoPost : ViewComponent
    {
        public IViewComponentResult Invoke(PostViewModel model)
        {
            return View(model);
        }
    }
}
