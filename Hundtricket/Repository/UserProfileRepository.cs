using Entities;
using Hundtricket.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly IDbContextFactory<HundtricketContext> _dbContextFactory;

        public UserProfileRepository(IDbContextFactory<HundtricketContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public void AddUserProfile(UserProfile userProfile)
        {
            var context = _dbContextFactory.CreateDbContext();

            context.UserProfiles.Add(userProfile);
            context.SaveChanges();
        }
    }
}
