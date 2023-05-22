namespace Entities
{
    public class Message
    {
        public int Id { get; set; }
        public string ToUserId { get; set; }
        public string FromUserId { get; set; }
        public string MessageText { get; set; }
        public DateTime TimeStamp { get; set; }
        public Guid ConversationId { get; set; }
    }
}
