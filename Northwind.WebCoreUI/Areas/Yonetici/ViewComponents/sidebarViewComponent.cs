using Microsoft.AspNetCore.Mvc;
using Northwind.Model.ViewModel.Areas.Yonetici.Sidebar;
using Northwind.WebCoreUI.Areas.Yonetici.Filters;

namespace Northwind.WebCoreUI.Areas.Yonetici.ViewComponents
{
    public class sidebarViewComponent:ViewComponent
    {
        ISessionManager _session;
        public sidebarViewComponent(ISessionManager session)
        {
            _session = session;
        }
        public IViewComponentResult Invoke()
        {
            sidebarVm vm = new sidebarVm();
            //vm.AktifYonetici = _session.AktifYonetici.UserName;

            return View(vm);
        }
    }
}
