using Entities;

namespace Infrastructure.Overviews
{
    public interface IPrivateMessageOverview
    {
        public void ReportConversation(List<Message> conversation, Guid userId, Guid reportedUserId, string reason);
        public void SetConversationId(string recipientId, string senderId);
    }
}
