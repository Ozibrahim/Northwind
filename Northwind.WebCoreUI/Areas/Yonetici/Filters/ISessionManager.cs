using Northwind.Model.Entity;

namespace Northwind.WebCoreUI.Areas.Yonetici.Filters
{
    public interface ISessionManager
    {
        public User AktifKullanici { get; set; }
        public User AktifYonetici { get; set; }
        public string GuvenlikKodu { get; set; }

    }
}
