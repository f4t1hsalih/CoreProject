using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents
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
