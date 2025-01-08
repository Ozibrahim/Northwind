using Microsoft.AspNetCore.Mvc;

namespace Northwind.WebCoreUI.Areas.Yonetici.ViewComponents
{
    public class footerViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
