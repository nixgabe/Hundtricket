using Entities;

namespace Infrastructure.Service
{
    public interface IMemberService 
    {
        public string MemberId { get; set; }

        public void SetMemberId(Guid memberId);

        public List<Message> SendMessage(Message message);

        public List<Message> GetChatMessages();

        public void MemberHasSignedIn();

        public bool IsMemberSignedIn { get; set; }
    }
}
