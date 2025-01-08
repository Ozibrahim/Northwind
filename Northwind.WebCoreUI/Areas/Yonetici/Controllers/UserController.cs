using Infrastucture.CrossCuttingConcern.Converters;
using Infrastucture.CrossCuttingConcern.Crypto;
using Infrastucture.Utility;
using Microsoft.AspNetCore.Mvc;
using Northwind.Business.Abstract;
using Northwind.Model.Entity;
using Northwind.Model.Statics;
using Northwind.Model.ViewModel.Areas.Yonetici;
using Northwind.WebCoreUI.Areas.Yonetici.Filters;
using Northwind.WebCoreUI.Extensions;
using System.Drawing;
using System.Drawing.Configuration;

namespace Northwind.WebCoreUI.Areas.Yonetici.Controllers
{

    [Area("Yonetici")]// aspect oriented programming

    public class UserController : Controller
    {
        private readonly IUserBs _userBs;
        private readonly ISessionManager _sessionManager;
        public UserController(IUserBs userBs, ISessionManager sessionManager)
        {
            _userBs = userBs;
            _sessionManager = sessionManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            LoginVm vm = new LoginVm();
            return View(vm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginVm user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }

            if (user.GuvenlikKodu != _sessionManager.GuvenlikKodu)
            {
                TempData["mesaj"] = "Guvenlik Kodu Hatalı";
                return View();
            }

            string CryptoPassword = CryptoManager.MD5Encrypt(user.Password);
            //string CryptoPassword = CryptoManager.AESEncrypt(user.Password,"Key");

            User kullanici =_userBs.Get(x=>x.UserName==user.UserName && x.Password== CryptoPassword);
            if (kullanici!=null)
            {
                _sessionManager.AktifYonetici=kullanici;

                //Doğru giriş
                return RedirectToAction("Index","Main");
            }
            else
            {
                //Hatalı giriş
                TempData["mesaj"] = "Hatalı Giriş.";
            }
                return View();
            
        }
        
        
        public FileContentResult GetCaptcha()
        {
            //return View();
            //return Json();
            //return RedirectToAction();
            //return PartialView();
            //return Content("merhaba");
            //return File();
            //string id = RouteData.Values["id"].ToString();
            
            CaptchaGenerator captcha = new CaptchaGenerator(6,"Verdana",20);
            Bitmap guvenlikResmi =  captcha.GuvenlikResmiUret();
            _sessionManager.GuvenlikKodu= captcha.olusturanString;
            byte[] guvenlikResmiByte = Converters.ImageToByteArray(guvenlikResmi);

            return File(guvenlikResmiByte,"image/jpg");
        }

    }


}
