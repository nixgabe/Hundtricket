using Entities;
using Hundtricket.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class ReportedMessageRepository : IReportedMessageRepository
    {
        private readonly IDbContextFactory<HundtricketContext> _dbContextFactory;

        public ReportedMessageRepository(IDbContextFactory<HundtricketContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public void ReportConversation(ReportedConversation reportedConversationInformation, List<Message> reportedConversation)
        {
            var context = _dbContextFactory.CreateDbContext();

            context.ReportedConversation.Add(reportedConversationInformation);

            foreach(var message in reportedConversation)
            {
                context.Message.Add(message);
            }

            context.SaveChanges();
        }
    }
}
