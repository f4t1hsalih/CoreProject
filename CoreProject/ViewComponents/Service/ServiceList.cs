using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Service
{
    public class ServiceList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
            var values = serviceManager.TGetListAll();
            return View(values);
        }
    }
}
