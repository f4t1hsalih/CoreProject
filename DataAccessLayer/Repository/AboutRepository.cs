using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repository
{
    public class AboutRepository : IAboutDal
    {
        public void Add(About entity)
        {
            using var c = new Context();
            c.Abouts.Add(entity);
            c.SaveChanges();
        }

        public void Delete(About entity)
        {
            using var c = new Context();
            c.Abouts.Remove(entity);
            c.SaveChanges();
        }

        public About GetById(int id)
        {
            using var c = new Context();
            return c.Abouts.Find(id);
        }

        public List<About> GetListAll()
        {
            using var c = new Context();
            return c.Abouts.ToList();
        }

        public void Update(About entity)
        {
            using var c = new Context();
            c.Abouts.Update(entity);
        }
    }
}
