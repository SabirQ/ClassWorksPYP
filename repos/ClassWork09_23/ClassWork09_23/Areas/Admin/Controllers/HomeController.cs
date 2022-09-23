using ClassWork09_23.Filters;
using ClassWork09_23.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using static System.Reflection.Metadata.BlobBuilder;

namespace ClassWork09_23.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        [RoleManager("moderator")]
        public IActionResult Index(string role)
        {
           
            return View();
        }
        [RoleManager("moderator")]
        public IActionResult Tables(string role)
        {

            return View();
        }
        [RoleManager("admin")]
        public IActionResult Profile(string role)
        {

            return View();
        }
    }
}
