using ClassWork09_23.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ClassWork09_23.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Portfolio> portfolios = new List<Portfolio>()
            {
                new Portfolio
                {
                    Image="books-1.jpg",
                    Desc="Random description",
                    Title="Title"
                },
                   new Portfolio
                {
                    Image="product-1.jpg",
                    Desc="Random description 1",
                    Title="Title 1"
                },
                      new Portfolio
                {
                    Image="books-1.jpg",
                    Desc="Random description 2",
                    Title="Title 2"
                },
                         new Portfolio
                {
                    Image="branding-1.jpg",
                    Desc="Random description 3",
                    Title="Title 3"
                },
            };
            return View(portfolios);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}