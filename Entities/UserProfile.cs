namespace Entities
{
    public class UserProfile
    {
        public Guid Id { get; set; }
        public string About { get; set; }
        public string Job { get; set; }
        public string Sexuality { get; set; }
        public string Gender { get; set; }
        public string Location { get; set; }
        public Guid UserHobbiesRelationshipsId { get; set; }
        public Guid UserPreferencesId { get; set; }

        public virtual UserHobbiesRelationShips UserHobbiesRelationShips { get; set; }
        public virtual UserPreferences UserPreferences { get; set; }
    }
}
