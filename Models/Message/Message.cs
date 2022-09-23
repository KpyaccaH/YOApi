namespace YOApi.Models.Message
{
    public class Message
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Body { get; set; }
        public bool Read { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public DateOnly Date { get; set; }
    }
}