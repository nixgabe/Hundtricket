using Entities;

namespace Infrastructure.Repository
{
    public interface IUserPreferencesRepository
    {
        public void AddUserPreferences(UserPreferences userPrefernces);
    }
}
