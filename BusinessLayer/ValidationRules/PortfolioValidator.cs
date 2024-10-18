using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator : AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Başlık alanı boş bırakılamaz.")
                .MinimumLength(3).WithMessage("Başlık alanı en az 3 karakter olmalıdır.")
                .MaximumLength(50).WithMessage("Başlık alanı en fazla 50 karakter olmalıdır.");

            RuleFor(x => x.ProjectUrl)
                .NotEmpty().WithMessage("Proje Url alanı boş bırakılamaz.")
                .MaximumLength(200).WithMessage("Proje Url alanı en fazla 200 karakter olmalıdır.");

            RuleFor(x => x.SmallImageUrl)
                .NotEmpty().WithMessage("Proje küçük resim alanı boş bırakılamaz.")
                .MaximumLength(200).WithMessage("Proje küçük resim alanı en fazla 200 karakter olmalıdır.");

            RuleFor(x => x.ImageUrl)
                .NotEmpty().WithMessage("Proje büyük resim alanı boş bırakılamaz.")
                .MaximumLength(200).WithMessage("Proje büyük resim alanı en fazla 200 karakter olmalıdır.");
        }
    }
}
