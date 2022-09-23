using YOApi.Data.Interfaces;
using YOApi.Models.Message;

namespace YOApi.Data.Implementations
{
    class MessageRepository : IMessageRepository
    {
        public void CreateMessage(Message message)
        {
            
        }
        public MessageBody GetMessageById(int id)
        {
            MessageBody message = new MessageBody { Body = "Вам повестка" };
            return message;
        }

        public void MessageUpdateReadStatus(int id)
        {
            
        }
    }
}