// MVC Framework features
using Microsoft.AspNetCore.Mvc;

// Define Controller
public class HomeController : Controller
{   
    // Handle home page requests
    public ActionResult Index()
    {
        ViewData["Title"] = "Home";
        return View();
    }
}
