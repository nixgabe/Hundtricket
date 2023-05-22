using Entities;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Infrastructure.Service
{
    public class MessageService : IMessageService
    {
        public string MemberId { get; set; }

        public List<Message> ChatMessages = new List<Message>();
        public Guid ConversationId {get; set; }

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

        public List<Message> GetCurrentConversation(string recipientId, string senderId)
        {
            var list = ChatMessages.Where(f => f.ToUserId == recipientId || f.FromUserId == recipientId).ToList();
            return list;
        }

        
        public void SetConversationId(string recipientId, string senderId)
        {
            var userSide = ChatMessages.Where(f => f.ToUserId == recipientId && f.FromUserId == senderId).Count();
            var senderSide = ChatMessages.Where(f => f.FromUserId == recipientId && f.ToUserId == senderId).Count();
            var totalMessages = userSide + senderSide;

            //if new conversaion
            if (totalMessages == 0)
            {
                ConversationId = Guid.NewGuid();
                return;
            }

            //if old conversation is being picked up
            ConversationId = ChatMessages.Where(f => f.ToUserId == recipientId && f.FromUserId == senderId).Select(s => s.ConversationId).FirstOrDefault();
        }
    }
}
