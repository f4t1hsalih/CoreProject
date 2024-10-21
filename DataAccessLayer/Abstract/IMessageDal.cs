using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IMessageDal : IGenericDal<Message>
    {
        void SetStatusToFalse(int id);
        List<Message> GetMessagesStatusTrue();
    }
}
