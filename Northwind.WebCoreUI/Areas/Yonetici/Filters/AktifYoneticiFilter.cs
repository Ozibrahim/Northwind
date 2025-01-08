using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Northwind.Model.Entity;
using Northwind.Model.Statics;
using Northwind.WebCoreUI.Extensions;

namespace Northwind.WebCoreUI.Areas.Yonetici.Filters
{
    public class AktifYoneticiFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {       //action metot çalıştırılmadan önce çalışır

            User user = context.HttpContext.Session.getObject<User>(SessionKeys.AktifYonetici);
            
            if (user == null) 
            {
                context.Result = new RedirectResult("/Yonetici/User/Login");
            }

            base.OnActionExecuting(context);
        }

        //public override void OnActionExecuted(ActionExecutedContext context)
        //{
        //    //action metot çalıştırıldıktan sonra çalışır

        //    base.OnActionExecuted(context);
        //}
    }
}
