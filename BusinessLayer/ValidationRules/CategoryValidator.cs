using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AuthorValidator: AbstractValidator<Category>
    {
        public AuthorValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adını Boş Geçemezsiniz.");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklamayı Boş Geçemezsiniz");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lütfen en az 3 karakterlik kategori adı girişi yapınız");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakterlik kategori adı girişi yapınız");
            RuleFor(x => x.CategoryDescription).MinimumLength(3).WithMessage("Lütfen en az 3 karakterlik kategori adı girişi yapınız");
            RuleFor(x => x.CategoryDescription).MaximumLength(500).WithMessage("Lütfen en fazla 50 karakterlik kategori adı girişi yapınız");
        }

        public ValidationResult Validate(Author b)
        {
            throw new NotImplementedException();
        }
    }
}
