using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adına boş geçemessin.");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklama boş geçemessin.");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("En az 3  kareter olmalı");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("en fazla 20 karakter den fazla olmaz.");
   

        }
    }
}
