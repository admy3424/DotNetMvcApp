// MVC Framework features
using Microsoft.AspNetCore.Mvc;

using System.IO;
using System.Linq;
using System.Collections.Generic;

// Define Controller
public class HomeController : Controller
{   
    // Handle home page requests
    public ActionResult Index()
    {
        // Set page title
        ViewData["Title"] = "Home";


        // Get image paths from the folder
        string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/gis_project_1");
        List<string> imagePaths = new List<string>();

         // Check if the directory exists before attempting to fetch images
        if (Directory.Exists(folderPath))
        {
            string[] files = Directory.GetFiles(folderPath);

            // Get relative paths for rendering in the view
            imagePaths = files.Select(file => "/images/gis_project_1/" + Path.GetFileName(file)).ToList();
        }

        // Pass image paths to the view
        return View(imagePaths);
    }
}
