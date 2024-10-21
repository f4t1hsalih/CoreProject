using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfMessageDal : GenericRepositoryDal<Message>, IMessageDal
    {
        public List<Message> GetMessagesStatusTrue()
        {
            using (var c = new Context())
            {
                var value = c.Messages.Where(x => x.Status == true).ToList();
                return value;
            }
        }

        public void SetStatusToFalse(int id)
        {
            using (var c = new Context())
            {
                var value = c.Messages.Find(id);
                if (value != null)
                {
                    value.Status = false;
                    c.Messages.Update(value);
                    c.SaveChanges();
                }
            }
        }
    }
}
