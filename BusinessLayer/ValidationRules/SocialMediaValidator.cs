using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class SocialMediaValidator : AbstractValidator<SocialMedia>
    {
        public SocialMediaValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("İsim alanı boş bırakılamaz.")
                .MaximumLength(100).WithMessage("İsim alanı en fazla 100 karakter olmalıdır.");

            RuleFor(x => x.Url)
                .NotEmpty().WithMessage("URL alanı boş bırakılamaz.")
                .MaximumLength(200).WithMessage("URL alanı en fazla 200 karakter olmalıdır.")
                .Must(url => Uri.IsWellFormedUriString(url, UriKind.Absolute))
                .WithMessage("Geçerli bir URL giriniz.");

            RuleFor(x => x.Icon)
                .NotEmpty().WithMessage("Simge alanı boş bırakılamaz.")
                .MaximumLength(100).WithMessage("Simge alanı en fazla 100 karakter olmalıdır.");

        }
    }
}
