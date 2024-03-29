using EweForum.Models;
using Microsoft.AspNetCore.Mvc;

namespace EweForum.ViewComponents
{
    public class UserList : ViewComponent
    {
        public IViewComponentResult Invoke(UserListModel model)
        {
            return View(model);
        }
    }
}
