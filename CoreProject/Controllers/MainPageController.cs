using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class MainPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeaderPartial()
        {

            return PartialView();
        }

        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SendMessage(Message message)
        {
            MessageManager messageMenager = new MessageManager(new EfMessageDal());
            message.Date = DateTime.Now;
            message.Status = true;
            messageMenager.TAdd(message);

            return PartialView("Index", "MainPage");
        }
    }
}
