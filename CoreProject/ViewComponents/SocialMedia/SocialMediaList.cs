using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.SocialMedia
{
    public class SocialMediaList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            SocialMediaManager socialMediaManager = new SocialMediaManager(new EfSocialMediaDal());
            var values = socialMediaManager.TGetListAll();
            return View(values);
        }
    }
}
