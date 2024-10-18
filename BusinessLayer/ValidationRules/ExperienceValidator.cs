using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class ExperienceValidator : AbstractValidator<Experience>
    {
        public ExperienceValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Başlık alanı boş bırakılamaz.")
                .MaximumLength(100).WithMessage("Başlık alanı en fazla 100 karakter olmalıdır.");

            RuleFor(x => x.Date)
                .NotEmpty().WithMessage("Tarih alanı boş bırakılamaz.")
                .MaximumLength(20).WithMessage("Tarih alanı en fazla 20 karakter olmalıdır.");

            RuleFor(x => x.ImageUrl)
                .NotEmpty().WithMessage("Resim URL alanı boş bırakılamaz.")
                .MaximumLength(200).WithMessage("Resim URL'si en fazla 200 karakter olmalıdır.");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Açıklama alanı boş bırakılamaz.")
                .MaximumLength(500).WithMessage("Açıklama en fazla 500 karakter olmalıdır.");
        }
    }
}
