using Entities;

namespace Infrastructure.Repository
{
    public interface IUserProfileRepository
    {
        public void AddUserProfile(UserProfile userProfile);
    }
}
