using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class TestimonialController : Controller
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
        void ViewBags(string pageName)
        {
            ViewBag.PageName = pageName;
            ViewBag.NewButton = "/Testimonial/AddTestimonial/";
        }
        public IActionResult Index()
        {
            ViewBags("Referans Listesi");
            var values = testimonialManager.TGetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddTestimonial()
        {
            ViewBags("Referans Ekle");
            return View();
        }
        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            TestimonialValidator rules = new TestimonialValidator();
            ValidationResult results = rules.Validate(testimonial);
            if (!results.IsValid)
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
            testimonialManager.TAdd(testimonial);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditTestimonial(int id)
        {
            ViewBags("Referans Düzenle");
            var value = testimonialManager.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult EditTestimonial(Testimonial testimonial)
        {
            TestimonialValidator rules = new TestimonialValidator();
            ValidationResult results = rules.Validate(testimonial);
            if (!results.IsValid)
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
            testimonialManager.TUpdate(testimonial);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteTestimonial(int id)
        {
            testimonialManager.TDelete(testimonialManager.TGetById(id));
            return RedirectToAction("Index");
        }

    }
}
