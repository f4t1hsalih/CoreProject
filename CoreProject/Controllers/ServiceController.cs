using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        void ViewBags(string pageName)
        {
            ViewBag.PageName = pageName;
            ViewBag.NewButton = "/Service/AddService/";
        }

        public IActionResult Index()
        {
            ViewBags("Hizmet Listesi");
            var values = serviceManager.TGetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            ViewBags("Hizmet Ekle");
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            ServiceValidator validations = new ServiceValidator();
            ValidationResult result = validations.Validate(service);
            if (!result.IsValid)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
            serviceManager.TAdd(service);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditService(int id)
        {
            ViewBags("Hizmet Düzenle");
            var value = serviceManager.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult EditService(Service service)
        {
            ServiceValidator validations = new ServiceValidator();
            ValidationResult result = validations.Validate(service);
            if (!result.IsValid)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
            serviceManager.TUpdate(service);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteService(int id)
        {
            serviceManager.TDelete(serviceManager.TGetById(id));
            return RedirectToAction("Index");
        }
    }
}
