using Microsoft.AspNetCore.Mvc;
using Northwind.Model.Entity;
using Northwind.WebCoreUI.Areas.Yonetici.Filters;

namespace Northwind.WebCoreUI.Areas.Yonetici.Controllers
{
    [Area("Yonetici")]
    public class MainController : Controller
    {
        private readonly ISessionManager _sessionManager;
        public MainController(ISessionManager sessionManager)
        {
            _sessionManager = sessionManager;
        }
        [AktifYoneticiFilter] // atribute olarak yazılabilmesi için ActionFilterAttribute kalıtım alması lazım
        public IActionResult Index()
        {
            return View();
        }
    }
}
