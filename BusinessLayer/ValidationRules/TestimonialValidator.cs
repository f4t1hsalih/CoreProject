using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class TestimonialValidator : AbstractValidator<Testimonial>
    {
        public TestimonialValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("İsim alanı boş bırakılamaz.")
                .MaximumLength(100).WithMessage("İsim alanı en fazla 100 karakter olmalıdır.");

            RuleFor(x => x.Position)
                .NotEmpty().WithMessage("Pozisyon alanı boş bırakılamaz.")
                .MaximumLength(50).WithMessage("Pozisyon alanı en fazla 50 karakter olmalıdır.");

            RuleFor(x => x.Company)
                .NotEmpty().WithMessage("Şirket alanı boş bırakılamaz.")
                .MaximumLength(100).WithMessage("Şirket alanı en fazla 100 karakter olmalıdır.");

            RuleFor(x => x.Comment)
                .NotEmpty().WithMessage("Yorum alanı boş bırakılamaz.")
                .MaximumLength(500).WithMessage("Yorum alanı en fazla 500 karakter olmalıdır.");

            RuleFor(x => x.ImageUrl)
                .NotEmpty().WithMessage("Resim alanı boş bırakılamaz.")
                .MaximumLength(200).WithMessage("Resim URL'si alanı en fazla 200 karakter olmalıdır.");
        }
    }
}
