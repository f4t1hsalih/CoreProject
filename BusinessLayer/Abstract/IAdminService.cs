using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IAdminService : IGenericService<Admin>
    {
        bool TGetByCredentials(string username, string password);
    }
}
