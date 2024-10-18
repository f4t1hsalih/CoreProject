using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Başlık alanı boş bırakılamaz.")
                .MaximumLength(100).WithMessage("Başlık alanı en fazla 100 karakter olmalıdır.");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Açıklama alanı boş bırakılamaz.")
                .MaximumLength(500).WithMessage("Açıklama alanı en fazla 500 karakter olmalıdır.");

            RuleFor(x => x.Age)
                .GreaterThan(0).WithMessage("Yaş 0'dan büyük olmalıdır.")
                .LessThan(150).WithMessage("Yaş 150'den küçük olmalıdır.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email alanı boş bırakılamaz.")
                .MaximumLength(50).WithMessage("Email en fazla 50 karakter olmalıdır.")
                .EmailAddress().WithMessage("Geçerli bir email adresi giriniz.");

            RuleFor(x => x.Phone)
                .MaximumLength(20).WithMessage("Telefon numarası en fazla 20 karakter olmalıdır.");

            RuleFor(x => x.Address)
                .MaximumLength(200).WithMessage("Adres en fazla 200 karakter olmalıdır.");

            RuleFor(x => x.ImageUrl)
                .MaximumLength(200).WithMessage("Resim URL'si en fazla 200 karakter olmalıdır.");
        }
    }
}
