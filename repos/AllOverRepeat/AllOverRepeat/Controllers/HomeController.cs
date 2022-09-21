using AllOverRepeat.DAL;
using AllOverRepeat.Models;
using AllOverRepeat.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AllOverRepeat.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index(string name=null)
        {
            if (string.IsNullOrEmpty(name))
            {
                HomeVM homeVM = new HomeVM
                {
                    Phones = _context.Phones.ToList(),
                    Computers = _context.Computers.ToList(),
                    Categories = _context.Categories.ToList(),
                };

                return View(homeVM);
            }
           
            Category category = _context.Categories.FirstOrDefault(x=>x.Name.ToLower().Contains(name.Trim().ToLower()));
            if (category == null) return NotFound();
            else
            {
                HomeVM homeVM = new HomeVM
                {
                    Phones = _context.Phones.Where(x => x.CategoryId == category.Id).ToList(),
                    Computers = _context.Computers.Where(x => x.CategoryId == category.Id).ToList(),
                    Categories = _context.Categories.Where(x => x.Id == category.Id).ToList(),
                };

                return View(homeVM);
            }
           

        }
    }
}
