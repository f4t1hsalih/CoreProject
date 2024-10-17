using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class SkillController : Controller
    {
        public IActionResult Index()
        {
            SkillManager skillManager = new SkillManager(new EfSkillDal());
            var skillValues = skillManager.TGetListAll();
            return View(skillValues);
        }
    }
}
