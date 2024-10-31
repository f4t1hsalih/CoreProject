using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface ISocialMediaService : IGenericService<SocialMedia>
    {
        void TAddStatusTrue(SocialMedia socialMedia);
    }
}
