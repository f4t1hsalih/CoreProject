using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AdminManager : IAdminService
    {
        private readonly IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public void TAdd(Admin entity)
        {
            throw new System.NotImplementedException();
        }

        public void TDelete(Admin entity)
        {
            throw new System.NotImplementedException();
        }

        public bool TGetByCredentials(string username, string password)
        {
            return _adminDal.GetByCredentials(username, password);
        }

        public Admin TGetById(int id)
        {
            return _adminDal.GetById(id);
        }

        public List<Admin> TGetListAll()
        {
            throw new System.NotImplementedException();
        }

        public void TUpdate(Admin entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
