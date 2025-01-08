using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Model.ViewModel.Areas.Yonetici
{
    public class LoginVm
    {
        //Fluent Validation

        //[Required(ErrorMessage = "Lütfen Kullanıcı Adı Giriniz")]
        public string? UserName { get; set; }
        //[Required(ErrorMessage ="Lütfen Sifre Giriniz")]
        //[StringLength(maximumLength:16,ErrorMessage ="Lütfen en az 8 karakter giriniz",MinimumLength =8)]
        //[RegularExpression("^(?=.{8,32}$)(?=.*[A-Z])(?=.*[a-z])(?=.*[@#$%*?^:;+-._,])(?=.*[0-9]).*",ErrorMessage ="Lütfen Büyük harf Kücük harf ve sembol giriniz.")]
        public string? Password { get; set; }
        public bool RememberMe { get; set; }

        public string GuvenlikKodu { get; set; }

    }
}
