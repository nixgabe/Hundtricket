using Entities;
using Hundtricket.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class UserPreferencesRepository : IUserPreferencesRepository
    {
        private readonly IDbContextFactory<HundtricketContext> _dbContextFactory;

        public UserPreferencesRepository(IDbContextFactory<HundtricketContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public void AddUserPreferences(UserPreferences userPrefernces)
        {
            var context = _dbContextFactory.CreateDbContext();

            context.UserPreferences.Add(userPrefernces);
            context.SaveChanges();
        }
    }
}
