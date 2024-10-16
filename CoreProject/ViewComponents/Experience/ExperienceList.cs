using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Experience
{
    public class ExperienceList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
            var values = experienceManager.TGetListAll();
            return View(values);
        }
    }
}
