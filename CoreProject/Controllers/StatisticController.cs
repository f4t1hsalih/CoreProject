using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
