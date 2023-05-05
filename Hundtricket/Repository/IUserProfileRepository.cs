using Entities;
using Infrastructure.Service.ViewModels;

namespace Infrastructure.Repository
{
    public interface IUserProfileRepository
    {
        public void AddUserProfile(UserProfile userProfile);
        public Task<UserProfile> GetUserProfileOnMemberId(Guid memberId);
        public void UpdateUserProfile(UserProfile userProfile);
        public Task<UserFilters> GetUserFilters(User user);     
        public Task<List<UserPreferencesViewModel>> GetAllUserFilters();
    }
}
