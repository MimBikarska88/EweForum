using Microsoft.AspNetCore.Mvc;

namespace EweForum.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View("Register","Account");
        }
    }
}
