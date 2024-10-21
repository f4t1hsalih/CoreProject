using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IMessageService : IGenericService<Message>
    {
        public void TSetStatusToFalse(int id);
        List<Message> TGetMessagesStatusTrue();
    }
}
