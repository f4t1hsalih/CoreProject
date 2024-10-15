using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents
{
    public class PortfolioList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
            var values = portfolioManager.TGetListAll();
            return View(values);
        }
    }
}
