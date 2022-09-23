namespace YOApi.Models.Message
{
    public class MessageFromUser
    {
        public string Title { get; set; }
        public string? Body { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public DateOnly Date { get; set; }
    }
}