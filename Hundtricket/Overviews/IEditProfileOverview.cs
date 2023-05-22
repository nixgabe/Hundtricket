using Entities;

namespace Infrastructure.Overviews
{
    public interface IEditProfileOverview
    {
        public User User { get; set; }
        public UserProfile UserProfile { get; set; }
        public List<Gender> Genders { get; set; }
        public UserPreferences UserPreferencesTemp { get; set; }
        public int GenderIdTemp { get; set; }
        public int PreferenceIdTemp { get; set; }
        public Task GatherAllInfo(Guid memberId);
        public void SaveChanges();
    }
}
