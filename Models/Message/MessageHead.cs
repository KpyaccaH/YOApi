namespace YOApi.Models.Message
{
    public class MessageHead
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public DateOnly Date { get; set; }
    }
}