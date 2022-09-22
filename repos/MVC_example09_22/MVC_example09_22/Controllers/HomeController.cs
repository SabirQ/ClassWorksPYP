using Microsoft.AspNetCore.Mvc;
using MVC_example09_22.Models;
using System.Diagnostics;

namespace MVC_example09_22.Controllers
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
            List<Product> products=new List<Product>()
            {
                new Product{Name="Pepsi",Price=15.99m,ProductImages=new List<ProductImage>(){ 
                new ProductImage
                {
                    Name="product-image-2-1.jpg",
                    Primary=true,
                    Alt="Product",
                },
                  new ProductImage
                {
                    Name="product-image-2-2.jpg",
                    Primary=false,
                    Alt="Product",
                }

                } },
                 new Product{Name="Cola",Price=20.99m,ProductImages=new List<ProductImage>(){
                new ProductImage
                {
                    Name="product-image-3-1.jpg",
                    Primary=true,
                    Alt="Product",
                },
                  new ProductImage
                {
                    Name="product-image-3-2.jpg",
                    Primary=false,
                    Alt="Product",
                }

                } },
                  new Product{Name="Twix",Price=5.99m,ProductImages=new List<ProductImage>(){
                new ProductImage
                {
                    Name="product-image-4-1.jpg",
                    Primary=true,
                    Alt="Product",
                },
                  new ProductImage
                {
                    Name="product-image-4-2.jpg",
                    Primary=false,
                    Alt="Product",
                }

                } }
            };
            return View(products);
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