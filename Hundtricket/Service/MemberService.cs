namespace Infrastructure.Service
{
    public class MemberService : IMemberService
    {
        public string MemberId { get; set; }

        public void SetMemberId(Guid memberId)
        {
            MemberId = memberId.ToString();
        }
    }
}
