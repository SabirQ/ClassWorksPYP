using Microsoft.AspNetCore.Mvc;

namespace ClassWork09_23.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View();
        }
    }
}
