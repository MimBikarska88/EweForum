using EweForum.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

public class ErrorMessage : ViewComponent
{
   

    public IViewComponentResult Invoke(MessageModel model)
    {
        return View(model);
    }

}