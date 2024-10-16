using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Feature
{
    public class FeatureList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
            var values = featureManager.TGetListAll();
            return View(values);
        }

    }
}
