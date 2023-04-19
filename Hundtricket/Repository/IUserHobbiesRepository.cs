using Entities;

namespace Infrastructure.Repository
{
    public interface IUserHobbiesRepository
    {
        public void AddMemberHobbies(UserHobbies userLikes);
    }
}
