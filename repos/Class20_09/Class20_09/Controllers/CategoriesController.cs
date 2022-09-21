using Class20_09.Models;
using Microsoft.AspNetCore.Mvc;

namespace Class20_09.Controllers
{
    public class CategoriesController : Controller
    {
       NorthwindContext _context=new NorthwindContext();
      
        public IActionResult Index()
        {
            return View(_context.Categories.ToList());
        }
    }
}
