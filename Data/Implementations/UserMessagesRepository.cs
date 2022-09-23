using YOApi.Data.Interfaces;
using YOApi.Models.Message;

namespace YOApi.Data.Implementations
{
    public class UserMessagesRepository : IUserMessagesRepository
    {
        private const string _incomings = "";
        private const string _senter = "";

        public virtual MessagesBox GetMessagesByUserIdWithSelection(int id, string selection)
        {
            MessagesBox messages;
            if (selection == "incoming")
            {
                messages = new MessagesBox {Count = 3, Messages = new MessageHead [] {
                                          new MessageHead {Id = 1, Title = "Привет", Sender = "VasyaPupkin@yomail.com", Recipient = "IvanGolubzov@yomail.com", Date = new DateOnly(2022, 09, 20)}, 
                                          new MessageHead {Id = 2, Title = "Скидки на пиво!", Sender = "Pivozavr@yomail.com", Recipient = "IvanGolubzov@yomail.com", Date = new DateOnly(2022, 09,20)},
                                          new MessageHead {Id = 3, Title = "Людьмила хочет познакомиться с вами...", Sender = "LudmilaStein@yomail.com", Recipient = "IvanGolubzov@yomail.com", Date = new DateOnly(2022, 08,20)},}};

                return messages;
            }
            if (selection == "sent")
            {
                messages = new MessagesBox {Count = 3, Messages = new MessageHead [] {
                                          new MessageHead {Id = 3, Title = "Привет", Sender = "VasyaPupkin@yomail.com", Recipient = "IvanGolubzov@yomail.com", Date = new DateOnly(2022, 09,20)}, 
                                          new MessageHead {Id = 4, Title = "Скидки на пиво!", Sender = "Pivozavr@yomail.com", Recipient = "IvanGolubzov@yomail.com", Date = new DateOnly(2022, 09,20)},
                                          new MessageHead {Id = 5, Title = "Людьмила хочет познакомиться с вами...", Sender = "LudmilaStein@yomail.com", Recipient = "IvanGolubzov@yomail.com", Date = new DateOnly(2022, 08,20)},}};

                return messages;
            }

            return messages = null;
        }
    }
}