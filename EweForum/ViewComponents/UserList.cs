using EweForum.Models;
using Microsoft.AspNetCore.Mvc;

namespace EweForum.ViewComponents
{
    public class UserList : ViewComponent
    {
        public IViewComponentResult Invoke(PaginationModel<ShortUserEditViewModel> model)
        {
            return View(model);
        }
    }
}
