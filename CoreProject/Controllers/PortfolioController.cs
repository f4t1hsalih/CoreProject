using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager postfolioManager = new PortfolioManager(new EfPortfolioDal());
        void ViewBags(string pageName)
        {
            ViewBag.PageName = pageName;
            ViewBag.NewButton = "/Portfolio/AddPortfolio/";
        }

        public IActionResult Index()
        {
            ViewBags("Proje Listesi");
            var values = postfolioManager.TGetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddPortfolio()
        {
            ViewBags("Proje Ekle");
            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            postfolioManager.TAdd(portfolio);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            ViewBags("Proje Düzenle");
            var value = postfolioManager.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult EditPortfolio(Portfolio portfolio)
        {
            postfolioManager.TUpdate(portfolio);
            return RedirectToAction("Index");
        }

        public IActionResult DeletePortfolio(int id)
        {
            postfolioManager.TDelete(postfolioManager.TGetById(id));
            return RedirectToAction("Index");
        }
    }
}
