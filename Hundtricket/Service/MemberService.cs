using Entities;

namespace Infrastructure.Service
{
    public class MemberService : IMemberService
    {
        public string MemberId { get; set; }

        public List<Message> ChatMessages = new List<Message>();

        public void SetMemberId(Guid memberId)
        {
            MemberId = memberId.ToString();
        }
        
        public List<Message> SendMessage(Message message )
        {
            ChatMessages.Add(message);

            return ChatMessages;
        }

        public List<Message> GetChatMessages()
        {
            return ChatMessages;
        }
    }
}
