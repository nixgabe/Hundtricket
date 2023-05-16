using Entities;

namespace Infrastructure.Service
{
    public class MessageService : IMessageService
    {
        public string MemberId { get; set; }

        public List<Message> ChatMessages = new List<Message>();

        public void SetMemberId(Guid memberId)
        {
            MemberId = memberId.ToString();
        }

        public List<Message> SendMessage(Message message)
        {
            ChatMessages.Add(message);
            return ChatMessages;
        }

        public List<Message> GetChatMessages()
        {
            return ChatMessages;
        }

        public List<Message> GetCurrentConversation(Message message)
        {
            //message.FromUserId = MemberId;
            //ChatMessages.Add(message);

            var list = ChatMessages.Where(f => f.ToUserId == message.ToUserId || f.FromUserId == message.ToUserId).ToList();
            var test = list.Where(f => f.ToUserId == MemberId || f.FromUserId == MemberId).ToList();

            return list;
        }

        public List<Message> GetCurrentConversation(string recipientId, string senderId)
        {
            var list = ChatMessages.Where(f => f.ToUserId == recipientId || f.FromUserId == recipientId).ToList();
            var test = list.Where(f => f.ToUserId == senderId || f.FromUserId == senderId).ToList();

            return list;
        }
    }
}
