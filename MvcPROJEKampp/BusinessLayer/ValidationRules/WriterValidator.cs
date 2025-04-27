using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {            
        
            RuleFor(x => x.WriterName).NotEmpty().WithMessage(" Yazar Adını Boş Geçemezsiniz.");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar Soyadını Boş Geçemezsiniz");
            RuleFor(x => x.WriterAbout).MinimumLength(3).WithMessage(" Hakkımda kısmını boş geçemezsiniz");
            RuleFor(x => x.WriterMail).MaximumLength(50).WithMessage("  Lütfen en az 2 karakter girişi yapın");
            RuleFor(x => x.WriterImage).MaximumLength(500).WithMessage(" Lütfen Fotoğraf Yükleyin");

        
    }

}
    
}

