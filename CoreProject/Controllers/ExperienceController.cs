using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());

        void ViewBags(string pageName)
        {
            ViewBag.PageName = pageName;
            ViewBag.NewButton = "/Experience/AddExperience/";
        }

        public IActionResult Index()
        {
            ViewBags("Deneyimler");
            var values = experienceManager.TGetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBags("Deneyim Ekle");
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            ExperienceValidator rules = new ExperienceValidator();
            ValidationResult results = rules.Validate(experience);
            if (!results.IsValid)
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
            experienceManager.TAdd(experience);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            ViewBags("Deneyim Düzenle");
            var value = experienceManager.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult EditExperience(Experience experience)
        {
            ExperienceValidator rules = new ExperienceValidator();
            ValidationResult results = rules.Validate(experience);
            if (!results.IsValid)
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
            experienceManager.TUpdate(experience);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteExperience(int id)
        {
            experienceManager.TDelete(experienceManager.TGetById(id));
            return RedirectToAction("Index");
        }
    }
}
