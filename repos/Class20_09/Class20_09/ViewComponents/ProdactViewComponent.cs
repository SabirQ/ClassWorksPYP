using Microsoft.AspNetCore.Mvc;

namespace Class20_09.ViewComponents
{
    public class ProdactViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            string text = "Code";
            return View(model:text);
        }
    }
}
