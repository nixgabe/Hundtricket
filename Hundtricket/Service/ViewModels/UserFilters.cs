using Entities;

namespace Infrastructure.Service.ViewModels
{
    public class UserFilters
    {
        public Guid UserId { get; set; }
        public int? UserAge { get; set; }
        public UserPreferencesViewModel UserPreferences { get; set; }
        public UserHobbies UserHobbies { get; set; }
    }
}
