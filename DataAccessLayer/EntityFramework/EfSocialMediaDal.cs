using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfSocialMediaDal : GenericRepositoryDal<SocialMedia>, ISocialMediaDal
    {
        public void AddStatusTrue(SocialMedia socialMedia)
        {
            using (var c = new Context())
            {
                socialMedia.Status = true;
                c.SocialMedias.Add(socialMedia);
                c.SaveChanges();
            }
        }
    }
}
