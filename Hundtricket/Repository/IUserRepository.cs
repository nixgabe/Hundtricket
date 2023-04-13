using Entities;

namespace Infrastructure.Repository
{
    public interface IUserRepository
    {
        public Task<User> CheckIfMemberExists(string email);
        public void RegisterNewMember(User newMember);
        public void UserIsSignedOn(string email);

        public Task<string> GetMemberEmail(Guid memberId);
        
    }
}
