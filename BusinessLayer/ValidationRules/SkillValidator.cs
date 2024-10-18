using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class SkillValidator : AbstractValidator<Skill>
    {
        public SkillValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Başlık alanı boş bırakılamaz.")
                .MaximumLength(100).WithMessage("Başlık alanı en fazla 100 karakter olmalıdır.");

            RuleFor(x => x.Value)
                .NotEmpty().WithMessage("Değer alanı boş bırakılamaz.")
                .MaximumLength(500).WithMessage("Değer alanı en fazla 500 karakter olmalıdır.");
        }
    }
}
