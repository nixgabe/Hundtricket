using Entities;
using Hundtricket.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IDbContextFactory<HundtricketContext> _dbContextFactory;

        public UserRepository(IDbContextFactory<HundtricketContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public Task<User> CheckIfMemberExists(string email)
        {
            var context = _dbContextFactory.CreateDbContext();

            var user = context.Users.Where(f => f.Email == email).FirstOrDefaultAsync();

            return user;
        }        

        public void RegisterNewMember(User newMember)
        {
            var context = _dbContextFactory.CreateDbContext();

            context.Users.Add(newMember);
            context.SaveChanges();
        }

        public void UserIsSignedOn(string email)
        {
            var context = _dbContextFactory.CreateDbContext();

            var user = context.Users.Where(f => f.Email == email).FirstOrDefault();
            user.IsSignedOn = true;
            context.SaveChanges();
        }
        public async Task<string> GetMemberEmail(Guid memberId)
        {
            var context = _dbContextFactory.CreateDbContext();

            return context.Users.Where(f => f.Id == memberId).Select(f => f.Email).FirstOrDefault();
        }
    }
}
