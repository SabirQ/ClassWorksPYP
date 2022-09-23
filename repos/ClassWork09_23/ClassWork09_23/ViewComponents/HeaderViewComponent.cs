using Microsoft.AspNetCore.Mvc;

namespace ClassWork09_23.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
