using YOApi.Models.Message;

namespace YOApi.Data.Interfaces
{
    public interface IUserMessagesRepository
    {
        public MessagesBox GetMessagesByUserIdWithSelection(int id, string selection);
    }
}