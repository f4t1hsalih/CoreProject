using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());

        void ViewBags(string pageName)
        {
            ViewBag.PageName = pageName;
            ViewBag.NewButton = "/Skill/AddSkill/";
        }

        public IActionResult Index()
        {
            ViewBags("Yetenek Listesi");

            var skillValues = skillManager.TGetListAll();
            return View(skillValues);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            ViewBags("Yetenek Ekle");
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            SkillValidator rules = new SkillValidator();
            ValidationResult result = rules.Validate(skill);
            if (!result.IsValid)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
            skillManager.TAdd(skill);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            ViewBags("Yetenek Düzenle");
            var value = skillManager.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult EditSkill(Skill skill)
        {
            SkillValidator rules = new SkillValidator();
            ValidationResult result = rules.Validate(skill);
            if (!result.IsValid)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
            skillManager.TUpdate(skill);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSkill(int id)
        {
            skillManager.TDelete(skillManager.TGetById(id));
            return RedirectToAction("Index");
        }
    }
}
