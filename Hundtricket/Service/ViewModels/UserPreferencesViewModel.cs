namespace Infrastructure.Service.ViewModels
{
    public class UserPreferencesViewModel
    {

        public Guid UserId { get; set; }
        public Guid FilterId { get; set; }
        public string? Gender { get; set; }
        //public int? LocationRange { get; set; }
        public int? YoungestAge { get; set; }
        public int? OldestAge { get; set; }
    }
}
