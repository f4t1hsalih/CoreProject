using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface ISocialMediaDal : IGenericDal<SocialMedia>
    {
        void AddStatusTrue(SocialMedia socialMedia);
    }
}
