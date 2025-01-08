using Microsoft.AspNetCore.Mvc;
using Northwind.Business.Abstract;
using Northwind.Model.Entity;

namespace Northwind.WebCoreUI.Areas.Yonetici.ViewComponents
{
    public class productlistViewComponent:ViewComponent
    {
        IProductBs _productBs;
        public productlistViewComponent(IProductBs productBs)
        {
            _productBs = productBs;
        }
        public IViewComponentResult Invoke()
        {
            List<Product> productlist = _productBs.GetAll();
            return View(productlist);
        }
    }
}
