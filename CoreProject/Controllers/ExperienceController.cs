using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
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
