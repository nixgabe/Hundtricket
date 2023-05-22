using Entities;

namespace Infrastructure.Service
{
    public interface IMessageService 
    {
        public string MemberId { get; set; }
        public Guid ConversationId { get; set; }

        public void SetMemberId(Guid memberId);

        public List<Message> SendMessage(Message message);

        public List<Message> GetChatMessages();

        public List<Message> GetCurrentConversation(string recipientId, string senderId);
        public void SetConversationId(string recipientId, string senderId);
    }
}
