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
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş geçemessin.");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar soyisim boş geçemessin.");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında kısmını boş geçemessin karakter den fazla olmaz.");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Hakkında kısmını boş geçemessin karakter den fazla olmaz.");
            RuleFor(x => x.WriterSurName).MinimumLength(2).WithMessage("en az 2 karakter den az olmaz.");

            RuleFor(x => x.WriterSurName).MaximumLength(50).WithMessage("en fazla 50 karakter den fazla olmaz.");


        }
    }
}
