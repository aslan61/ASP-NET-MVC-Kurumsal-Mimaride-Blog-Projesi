using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator: AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Maili Boş Geçemezsiniz.");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad Kısmını Boş Geçemezsiniz.");
            RuleFor(x => x.SurName).NotEmpty().WithMessage("Soyad Kısmını Boş Geçemezsiniz.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu Boş Geçemezsiniz.");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Mesaj İçeriğini Boş Geçemezsiniz.");
        }
    }
}
