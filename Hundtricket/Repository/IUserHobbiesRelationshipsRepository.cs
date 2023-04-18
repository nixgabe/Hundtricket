using Entities;

namespace Infrastructure.Repository
{
    public interface IUserHobbiesRelationshipsRepository
    {
        public void AddUserHobbiesRelationship(UserHobbiesRelationShips userHobbiesRelationShips);
    }
}
