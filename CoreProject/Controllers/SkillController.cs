using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class SkillController : Controller
    {
        void ViewBags(string pageName)
        {
            ViewBag.PageName = pageName;
            ViewBag.NewButton = "/Skill/AddSkill/";
        }

        public IActionResult Index()
        {
            ViewBags("Yetenek Listesi");

            SkillManager skillManager = new SkillManager(new EfSkillDal());
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
            SkillManager skillManager = new SkillManager(new EfSkillDal());
            skillManager.TAdd(skill);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            SkillManager skillManager = new SkillManager(new EfSkillDal());
            var value = skillManager.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult EditSkill(Skill skill)
        {
            ViewBags("Yetenek Düzenle");
            SkillManager skillManager = new SkillManager(new EfSkillDal());
            skillManager.TUpdate(skill);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSkill(int id)
        {
            SkillManager skillManager = new SkillManager(new EfSkillDal());
            skillManager.TDelete(skillManager.TGetById(id));
            return RedirectToAction("Index");
        }
    }
}
