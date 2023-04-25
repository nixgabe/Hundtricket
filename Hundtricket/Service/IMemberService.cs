namespace Infrastructure.Service
{
    public interface IMemberService 
    {
        public string MemberId { get; set; }

        public void SetMemberId(Guid memberId);


    }
}
