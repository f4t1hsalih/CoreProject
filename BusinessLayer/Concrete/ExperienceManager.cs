using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;

namespace BusinessLayer.Concrete
{
    public class ExperienceManager : IExperienceService
    {
        private readonly IExperienceDal _experienceDal;

        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public void TAdd(EntityLayer.Concrete.Experience entity)
        {
            _experienceDal.Add(entity);
        }

        public void TDelete(EntityLayer.Concrete.Experience entity)
        {
            _experienceDal.Delete(entity);
        }

        public EntityLayer.Concrete.Experience TGetById(int id)
        {
            return _experienceDal.GetById(id);
        }

        public List<EntityLayer.Concrete.Experience> TGetListAll()
        {
            return _experienceDal.GetListAll();
        }

        public void TUpdate(EntityLayer.Concrete.Experience entity)
        {
            _experienceDal.Update(entity);
        }
    }
}
