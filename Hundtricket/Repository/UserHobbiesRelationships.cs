using Entities;
using Hundtricket.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class UserHobbiesRelationships : IUserHobbiesRelationshipsRepository
    {
        private readonly IDbContextFactory<HundtricketContext> _dbContextFactory;

        public UserHobbiesRelationships(IDbContextFactory<HundtricketContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public void AddUserHobbiesRelationship(UserHobbiesRelationShips userHobbiesRelationShips)
        {
            var context = _dbContextFactory.CreateDbContext();

            context.UserHobbiesRelationShips.Add(userHobbiesRelationShips);

            context.SaveChanges();
        }
    }
}
