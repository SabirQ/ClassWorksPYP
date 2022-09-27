using Microsoft.AspNetCore.Mvc;
using MVCSignalR.Models;
using MVCSignalR.Repositories;
using System.Diagnostics;

namespace MVCSignalR.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductRepository _repository;

        public HomeController(ILogger<HomeController> logger, IProductRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Product()
        {
            return Ok(_repository.GetAll());
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