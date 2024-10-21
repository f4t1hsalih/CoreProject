using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Başlık alanı boş bırakılamaz.")
                .MaximumLength(100).WithMessage("Başlık alanı en fazla 100 karakter olmalıdır.");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Açıklama alanı boş bırakılamaz.")
                .MaximumLength(500).WithMessage("Açıklama alanı en fazla 500 karakter olmalıdır.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email alanı boş bırakılamaz.")
                .MaximumLength(100).WithMessage("Email en fazla 100 karakter olmalıdır.")
                .EmailAddress().WithMessage("Geçerli bir email adresi giriniz.");

            RuleFor(x => x.Phone)
                .NotEmpty().WithMessage("Telefon alanı boş bırakılamaz.")
                .MaximumLength(20).WithMessage("Telefon numarası en fazla 20 karakter olmalıdır.")
                .Matches(@"^\d{3}(\s\d{3}){1,2}(\s\d{2}){2}$")
                .WithMessage("Geçerli bir telefon numarası girin.");
        }
    }
}
