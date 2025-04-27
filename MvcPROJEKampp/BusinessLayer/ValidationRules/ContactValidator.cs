using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>

    {
        public ContactValidator()

        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage(" Mail adını boş geçemezsiniz.");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Mesaj Kısmını boş geçemezsiniz.");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("En Az 3 karakter giriniz.");
            RuleFor(x => x.Subject).MaximumLength(1000).WithMessage("Maksimum 1000 karakter. Lütfen 2. Bir mesaj gönderiniz.");
            RuleFor(x => x.Message).MinimumLength(50).WithMessage(" En Az 50 Karakterden oluşan bir mesaj yazınız.");
           


        }




    }


}
        

