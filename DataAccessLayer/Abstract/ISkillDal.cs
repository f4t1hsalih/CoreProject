using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface ISkillDal
    {
        void Add(Skill skill);
        void Update(Skill skill);
        void Delete(Skill skill);
        List<Skill> GetListAll();

    }
}
