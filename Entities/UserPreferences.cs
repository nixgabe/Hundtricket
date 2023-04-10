namespace Entities
{
    public class UserPreferences
    {
        public Guid Id { get; set; }    
        public string Gender { get; set; }
        public int LocationRange { get; set; }
        public int YoungestAge { get; set; }
        public int OldestAge { get; set; }
    }
}
