using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class FeatureValidator : AbstractValidator<Feature>
    {
        public FeatureValidator()
        {
            RuleFor(x => x.Header)
                .NotEmpty().WithMessage("Başlık alanı boş bırakılamaz.")
                .MaximumLength(200).WithMessage("Başlık alanı en fazla 200 karakter olmalıdır.");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("İsim alanı boş bırakılamaz.")
                .MaximumLength(100).WithMessage("İsim alanı en fazla 100 karakter olmalıdır.");

            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Açıklama alanı boş bırakılamaz.")
                .MaximumLength(150).WithMessage("Açıklama alanı en fazla 150 karakter olmalıdır.");
        }
    }
}
