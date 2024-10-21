using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;

namespace CoreProject.Controllers
{
    public class MessageController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());

        public IActionResult Index()
        {
            var values = messageManager.TGetMessagesStatusTrue();
            return View(values);
        }
        public IActionResult DeleteMessage(int id)
        {
            messageManager.TSetStatusToFalse(id);
            return RedirectToAction("Index");
        }
    }
}
