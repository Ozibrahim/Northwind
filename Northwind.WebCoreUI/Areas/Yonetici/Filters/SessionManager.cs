using Northwind.Model.Entity;
using Northwind.Model.Statics;
using Northwind.WebCoreUI.Extensions;

namespace Northwind.WebCoreUI.Areas.Yonetici.Filters
{
    public class SessionManager : ISessionManager
    {
        IHttpContextAccessor _httpContextAccessor;
        public SessionManager(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public User AktifKullanici
        {
            get
            {
                return _httpContextAccessor.HttpContext.Session.getObject<User>(SessionKeys.AktifKullanici);
            }
            set
            {
                _httpContextAccessor.HttpContext.Session.setObject(SessionKeys.AktifKullanici, value);

            }
        }

        public User AktifYonetici
        {
            get
            {
                return _httpContextAccessor.HttpContext.Session.getObject<User>(SessionKeys.AktifYonetici);
            }
            set
            {
                _httpContextAccessor.HttpContext.Session.setObject(SessionKeys.AktifYonetici, value);

            }




        }
        public string GuvenlikKodu
        {
            get
            {
                return _httpContextAccessor.HttpContext.Session.getObject<string>(SessionKeys.GuvenlikKodu);
            }
            set
            {
                _httpContextAccessor.HttpContext.Session.setObject(SessionKeys.GuvenlikKodu, value);

            }




        }
    }
}
