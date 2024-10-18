using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator : AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Başlık alanı boş bırakılamaz.");
            RuleFor(x => x.ProjectUrl).NotEmpty().WithMessage("Proje Url alanı boş bırakılamaz.");
            RuleFor(x => x.SmallImageUrl).NotEmpty().WithMessage("Proje küçük resim alanı boş bırakılamaz.");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Proje büyük resim alanı boş bırakılamaz.");

            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Başlık alanı en az 3 karakter olmalıdır.");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Başlık alanı en fazla 50 karakter olmalıdır.");
        }
    }
}
