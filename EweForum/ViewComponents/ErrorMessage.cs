using EweForum.Models;
using Microsoft.AspNetCore.Mvc;

public class ErrorMessage : ViewComponent
{
   

    public IViewComponentResult Invoke(MessageModel model)
    {
        return View(model);
    }

}