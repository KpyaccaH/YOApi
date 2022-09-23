using YOApi.Models.Message;

namespace YOApi.Data.Interfaces
{
    public interface IMessageRepository
    {
        public void CreateMessage(Message message);
        public MessageBody GetMessageById(int id);
        public void MessageUpdateReadStatus(int id);
    }
}