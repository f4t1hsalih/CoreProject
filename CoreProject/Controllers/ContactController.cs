using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());

        void ViewBags(string pageName)
        {
            ViewBag.PageName = pageName;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBags("İletişim Paneli Bilgileri");
            var value = contactManager.TGetById(1);
            return View(value);
        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            ContactValidator validations = new ContactValidator();
            ValidationResult result = validations.Validate(contact);
            if (!result.IsValid)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
            contactManager.TUpdate(contact);
            return RedirectToAction("Index");
        }

    }
}
