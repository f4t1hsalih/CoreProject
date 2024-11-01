using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfAdminDal : GenericRepositoryDal<Admin>, IAdminDal
    {
        public bool GetByCredentials(string username, string password)
        {
            using (var context = new Context())
            {
                var admin = context.Admins.FirstOrDefault(x => x.Username == username && x.Password == password);
                return admin != null; // Kullanıcı bulunursa true, bulunamazsa false döner
            }
        }
    }
}
