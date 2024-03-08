using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace EweForum.Models
{
    public class Modal : ViewComponent
    {
        public string Title { get; set; } = string.Empty;
        public string TextContent { get; set; } = string.Empty;

        public string ConfirmUrl { get; set; } = string.Empty;

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
