using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator:AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Proje adı boş geçilemez!");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel boş geçilemez!");
            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Görsel boş geçilemez!");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat boş geçilemez!");
            RuleFor(x => x.Value).NotEmpty().WithMessage("Değer boş geçilemez!");
            RuleFor(x => x.ImageUrl).MinimumLength(5).WithMessage("Proje adı en az 5 karakter içermelidir!");
            RuleFor(x => x.ImageUrl).MaximumLength(100).WithMessage("Proje adı en fazla 100 karakter içermelidir!");
        }
    }
}
