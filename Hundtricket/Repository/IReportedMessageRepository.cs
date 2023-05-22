using Entities;

namespace Infrastructure.Repository
{
    public interface IReportedMessageRepository
    {
        public void ReportConversation(ReportedConversation reportedConversationInformation, List<Message> reportedConversation);
    }
}
