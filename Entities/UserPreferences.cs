namespace Entities
{
    public class UserPreferences
    {
        public Guid Id { get; set; }    
        public int? GenderId { get; set; }
        public int? LocationRange { get; set; }
        public int? YoungestAge { get; set; }
        public int? OldestAge { get; set; }

        public virtual Gender Gender { get; set; }
    }
}
