using Entities;
using Infrastructure.Service;

namespace Infrastructure.Overviews
{
    public class PrivateMessageOverview : IPrivateMessageOverview
    {
        private readonly IMessageService _messageService;
        public PrivateMessageOverview(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void ReportConversation(List<Message> conversation, Guid userId, Guid reportedUserId)
        {
            var conversationId = Guid.NewGuid();

        }

        //works weird with id setting since it keeps convos seperate,
        //the second message gets it's own because the messages don't exist and list empty, but the rest follows initial Id
        //So that means the id setting is flipped
        //Might not be a bad idea?

        //Only works one way though, should work both
        public void SetConversationId(string recipientId, string senderId)
        {
            var allMessages = _messageService.GetChatMessages();

            var userSide = allMessages.Where(f => f.ToUserId == recipientId && f.FromUserId == senderId).Count();
            var senderSide = allMessages.Where(f => f.FromUserId == recipientId && f.ToUserId == senderId).Count();
            var total = userSide + senderSide;

            //if new conversaion
            if (total == 0)
            {
                _messageService.ConversationId = Guid.NewGuid();
                return;
            }

            //if old conversation is being picked up
            _messageService.ConversationId = allMessages.Where(f => f.ToUserId == recipientId && f.FromUserId == senderId).Select(s => s.ConversationId).FirstOrDefault();
        }
    }
}
