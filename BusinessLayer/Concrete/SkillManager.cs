using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class SkillManager : ISkillService
    {
        private readonly ISkillDal _skillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public void TAdd(Skill entity)
        {
            _skillDal.Add(entity);
        }

        public void TDelete(Skill entity)
        {
            _skillDal.Delete(entity);
        }

        public Skill TGetById(int id)
        {
            return _skillDal.GetById(id);
        }

        public List<Skill> TGetListAll()
        {
            return _skillDal.GetListAll();
        }

        public void TUpdate(Skill entity)
        {
            _skillDal.Update(entity);
        }
    }
}
