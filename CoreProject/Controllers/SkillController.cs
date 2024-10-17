using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class SkillController : Controller
    {

        public IActionResult Index()
        {
            ViewBag.PageName = "Yetenek Listesi";
            ViewBag.NewButton = "/Skill/AddSkill/";

            SkillManager skillManager = new SkillManager(new EfSkillDal());
            var skillValues = skillManager.TGetListAll();
            return View(skillValues);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            ViewBag.PageName = "Yetenek Ekle";
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            ViewBag.PageName = "Yetenek Ekle";
            SkillManager skillManager = new SkillManager(new EfSkillDal());
            skillManager.TAdd(skill);
            return RedirectToAction("Index");
        }
    }
}
