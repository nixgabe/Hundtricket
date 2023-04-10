namespace Entities
{
    public class UserDogRelationships
    {
        public Guid Id { get; set; }
        public Guid UsersDogId { get; set; }
        
        public ICollection<UserDogs> UserDogs { get; set; }
        
    }
}
