// MVC Framework features
using Microsoft.AspNetCore.Mvc;

// Lists for data storage
using System.Collections.Generic;

// Tools to filter data
using System.Linq;

// Define Controller
public class HomeController : Controller
{
    // Set fake database using a list 
    private static List<Post> _posts = new List<Post>();

    // Initialize fake data for scroll
    static HomeController()
    {
        for (int i = 1; i <= 100; i++)
        {
            _posts.Add(new Post
            {
                Id = i,
                Title = $"Post {i}",
                Content = $"This is the content of post {i}."
            });
        }
    }

    // Handle home page requests
    public IActionResult Index()
    {
        ViewData["Title"] = "Home";
        return View();
    }

    // Handle infinite scroll requests
    [HttpGet]
    public JsonResult GetPosts(int page = 1, int pageSize = 10)
    {
        var posts = _posts
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();

        return Json(posts);
    }
}
