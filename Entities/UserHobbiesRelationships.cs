namespace Entities
{
    public class UserHobbiesRelationShips
    {
        public Guid Id { get; set; }
        public Guid LikesId { get; set; }
        public Guid DislikesId { get; set; }

        public ICollection<UserHobbies> UserHobbies { get; set; }
    }
}
