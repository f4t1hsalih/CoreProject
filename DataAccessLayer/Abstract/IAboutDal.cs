using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IAboutDal
    {
        void Insert(About about);
        void Delete(About about);
        void Update(About about);
        List<About> GetListAll();

    }
}
