using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.About
{
    public class AboutList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            AboutManager aboutManager = new AboutManager(new EfAboutDal());
            var values = aboutManager.TGetListAll();
            return View(values);
        }
    }
}
