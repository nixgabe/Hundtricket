using Entities;

namespace Infrastructure.Repository
{
    public interface IUserProfileRepository
    {
        public void AddUserProfile(UserProfile userProfile);
        public Task<UserProfile> GetUserProfileOnMemberId(Guid memberId);
        public void UpdateUserProfile(UserProfile userProfile);
    }
}
