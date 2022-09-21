using Microsoft.AspNetCore.Mvc;

namespace Class20_09.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
