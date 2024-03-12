using EweForum.Models;
using Microsoft.AspNetCore.Mvc;

namespace EweForum.ViewComponents
{
    public class SuccessMessage : ViewComponent
    {
        public IViewComponentResult Invoke(MessageModel model)
        {
            return View(model);
        }
    }
}
