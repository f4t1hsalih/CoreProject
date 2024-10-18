using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        void ViewBags(string pageName)
        {
            ViewBag.PageName = pageName;
            ViewBag.NewButton = "";
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBags("Hakkımda");
            var value = aboutManager.TGetById(1);
            return View(value);
        }
        [HttpPost]
        public IActionResult Index(About about)
        {
            AboutValidator rules = new AboutValidator();
            ValidationResult results = rules.Validate(about);
            if (!results.IsValid)
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
            aboutManager.TUpdate(about);
            return View(about);
        }
    }
}
