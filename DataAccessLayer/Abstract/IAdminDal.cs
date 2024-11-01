using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IAdminDal : IGenericDal<Admin>
    {
        bool GetByCredentials(string username, string password);
    }
}
