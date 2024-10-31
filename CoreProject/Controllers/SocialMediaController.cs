using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class SocialMediaController : Controller
    {
        SocialMediaManager socialMediaManager = new SocialMediaManager(new EfSocialMediaDal());
        void ViewBags(string pageName)
        {
            ViewBag.PageName = pageName;
            ViewBag.NewButton = "/SocialMedia/AddSocialMedia/";
        }
        public IActionResult Index()
        {
            ViewBags("Sosyal Medya Listesi");
            var values = socialMediaManager.TGetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSocialMedia()
        {
            ViewBags("Sosyal Medya Ekle");
            return View();
        }
        [HttpPost]
        public IActionResult AddSocialMedia(SocialMedia socialMedia)
        {
            SocialMediaValidator validations = new SocialMediaValidator();
            ValidationResult result = validations.Validate(socialMedia);
            if (!result.IsValid)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
            socialMediaManager.TAdd(socialMedia);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditSocialMedia(int id)
        {
            ViewBags("Sosyal Medya Düzenle");
            var value = socialMediaManager.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult EditSocialMedia(SocialMedia socialMedia)
        {
            SocialMediaValidator validations = new SocialMediaValidator();
            ValidationResult result = validations.Validate(socialMedia);
            if (!result.IsValid)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
            socialMediaManager.TUpdate(socialMedia);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSocialMedia(int id)
        {
            socialMediaManager.TDelete(socialMediaManager.TGetById(id));
            return RedirectToAction("Index");
        }
    }
}
