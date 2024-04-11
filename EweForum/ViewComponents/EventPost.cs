using EweForum.Models;
using Microsoft.AspNetCore.Mvc;

namespace EweForum.ViewComponents
{
    public class EventPost : ViewComponent
    {
        public IViewComponentResult Invoke(ViewPostModelDetails model)
        {
            return View(model);
        }
    }
}
