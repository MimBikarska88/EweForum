using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

public class Header : ViewComponent
{
   

    public IViewComponentResult Invoke()
    {
        return View();
    }

}