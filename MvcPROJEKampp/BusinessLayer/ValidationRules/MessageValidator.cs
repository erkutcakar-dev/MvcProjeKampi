using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator() 
        
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage(" Alıcı adresini boş geçemezsiniz.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage(" Konuyu boş geçemezsiniz.");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("  Mesajı boş geçemezsiniz.");
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage(" Gönderici mesajını boş geçemezsiniz.");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("En Az 3 karakter giriniz.");
            RuleFor(x => x.Subject).MaximumLength(1000).WithMessage("Maksimum 1000 karakter. Lütfen 2. Bir mesaj gönderiniz.");
           


        }
    } 
}
