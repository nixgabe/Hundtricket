namespace Entities
{
    public class ReportedConversation
    {
        public Guid Id { get; set; }
        public Guid ReportedUser { get; set; }
        public Guid Reporter { get; set; }
        public string Reason { get; set; }
        public Guid ConversationId { get; set; }

    }
}
