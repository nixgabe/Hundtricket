using Entities;
using Infrastructure.Service.ViewModels;

namespace Infrastructure.Repository
{
    public interface IUserPreferencesRepository
    {
        public void AddUserPreferences(UserPreferences userPrefernces);        

    }
}
