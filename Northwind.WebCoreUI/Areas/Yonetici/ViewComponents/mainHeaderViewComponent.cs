using Microsoft.AspNetCore.Mvc;

namespace Northwind.WebCoreUI.Areas.Yonetici.ViewComponents
{
    public class mainHeaderViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
