using Microsoft.AspNetCore.Mvc;

namespace SerephimProjects.Controllers
{
    public class HomeController : Controller
    {
        // This action returns the index page
        [HttpGet]
        public IActionResult Index()
        {
            // Return the index.html file located in the specified path
            return PhysicalFile("~/www/index.html");
        }


         public IActionResult Home()
        {
            // Return the index.html file located in the specified path
            return PhysicalFile("~/");
        }
    }


}