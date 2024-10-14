using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class MainPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
