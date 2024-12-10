using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ImageValidator :AbstractValidator<Image>
    {
      public  ImageValidator()
        {
            RuleFor(X => X.Title).NotEmpty().WithMessage("Görsel Başlıgı Boş Geçilmez");
            RuleFor(X => X.Description).NotEmpty().WithMessage("Görsel Açıklaması Boş Geçilmez");
            RuleFor(X => X.ImageUrl).NotEmpty().WithMessage("Görsel Yolu Boş Geçilmez");
            RuleFor(X => X.Title).MaximumLength(20).WithMessage("20  Krakterden Fazla Olmasın ");
            RuleFor(X => X .Description).MaximumLength(50).WithMessage("50  En Az Krakterden olsun ");
            RuleFor(X => X .Description).MinimumLength(20).WithMessage("20  Krakterden Fazla Olmasın ");

        }
    }
}
