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
        
        public async Task<string> GetMemberEmail(Guid memberId)
        {
            var context = _dbContextFactory.CreateDbContext();

            return context.Users.Where(f => f.Id == memberId).Select(f => f.Email).FirstOrDefault();
        }

        public async Task<User> GetMemberOnId(Guid memberId)
        {
            var context = _dbContextFactory.CreateDbContext();

            return context.Users.Where(f => f.Id == memberId).FirstOrDefault();
        }

        public void UpdateUser(User member)
        {
            var context = _dbContextFactory.CreateDbContext();

            var original = context.Users.Where(f => f.Id == member.Id).FirstOrDefault();

            original.FirstName = member.FirstName;
            original.LastName = member.LastName;
            original.Email = member.Email;

            context.SaveChanges();
        }

        public async Task<List<Gender>> GetGendersList()
        {
            var context = _dbContextFactory.CreateDbContext();

            return await context.Genders.ToListAsync();
        }
    }
}
