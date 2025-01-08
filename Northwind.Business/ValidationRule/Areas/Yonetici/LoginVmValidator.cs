using FluentValidation;
using Northwind.Model.ViewModel.Areas.Yonetici;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.ValidationRule.Areas.Yonetici
{
    public class LoginVmValidator:AbstractValidator<LoginVm>
    {
        public LoginVmValidator()
        {
            RuleFor(x => x.UserName).MinimumLength(8).WithMessage("Lütfen 8 karakter giriniz").NotEmpty().WithMessage("Lütfen Boş Bırakmayınız"); /*Must(UserNameAlreadyUsed);*/
            RuleFor(x => x.Password).MinimumLength(8).WithMessage("Lütfen 8 karakter giriniz").NotEmpty().WithMessage("Lütfen Boş Bırakmayınız");
        }

        //public bool UserNameAlreadyUsed(string arg)
        //{
        //    //arg = UserName;

        //    if (true)
        //    {
        //        return true;
        //    }
        //}
    }
}
