using Microsoft.AspNetCore.Mvc;

namespace AllOverRepeat.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<string> words=new List<string>() { "random address","random mail","random +845623 234 234"};
            return View( words);
        }
    }
}
