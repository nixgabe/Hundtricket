namespace Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } = "Blank";
        public Guid UserDogRelationshipsId { get; set; }
        public Guid UserProfileId { get; set; }        
        
        public virtual UserDogRelationships UserDogRelationships { get; set; }
        public virtual UserProfile UserProfile { get; set; }
    }
}
