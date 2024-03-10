using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EweForum.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        
    }
}
