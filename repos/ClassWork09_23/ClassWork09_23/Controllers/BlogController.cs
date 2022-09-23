using Microsoft.AspNetCore.Mvc;

namespace ClassWork09_23.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
