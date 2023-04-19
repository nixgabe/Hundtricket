using Entities;
using Hundtricket.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class UserHobbiesRepository : IUserHobbiesRepository
    {
        private readonly IDbContextFactory<HundtricketContext> _dbContextFactory;

        public UserHobbiesRepository(IDbContextFactory<HundtricketContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public void AddMemberHobbies(UserHobbies userLikes)
        {
            var context = _dbContextFactory.CreateDbContext();

            context.UserHobbies.Add(userLikes);            
            context.SaveChanges();
        }
        
    }
}
