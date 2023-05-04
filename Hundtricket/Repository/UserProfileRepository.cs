using Entities;
using Hundtricket.Context;
using Infrastructure.Service.ViewModels;
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

        public async Task<UserProfile> GetUserProfileOnMemberId(Guid memberId)
        {
            var context = _dbContextFactory.CreateDbContext();
            return await context.UserProfiles.Where(f => f.Id == memberId).Include(s => s.UserHobbies)
                .Include(d => d.UserPreferences)
                .FirstOrDefaultAsync();
        }

        public void UpdateUserProfile(UserProfile userProfile)
        {
            var context = _dbContextFactory.CreateDbContext();
            
            var originalProfile = context.UserProfiles.Where(f => f.Id == userProfile.Id).FirstOrDefault();

            originalProfile.Gender = userProfile.Gender;
            originalProfile.Sexuality = userProfile.Sexuality;
            originalProfile.Job = userProfile.Job;
            originalProfile.Location = userProfile.Location;
            originalProfile.About = userProfile.About;

            var originalPreferences = context.UserPreferences.Where(f => f.Id == userProfile.UserPreferencesId).FirstOrDefault();

            originalPreferences.Gender = userProfile.UserPreferences.Gender;
            originalPreferences.LocationRange = userProfile.UserPreferences.LocationRange;
            originalPreferences.YoungestAge = userProfile.UserPreferences.YoungestAge;
            originalPreferences.OldestAge = userProfile.UserPreferences.OldestAge;

            var originalHobbies = context.UserHobbies.Where(f => f.Id == userProfile.UserHobbiesId).FirstOrDefault();

            originalHobbies.Nature = userProfile.UserHobbies.Nature;
            originalHobbies.Hiking = userProfile.UserHobbies.Hiking;
            originalHobbies.Swimming = userProfile.UserHobbies.Swimming;
            originalHobbies.Music = userProfile.UserHobbies.Music;
            originalHobbies.Gaming = userProfile.UserHobbies.Gaming;
            originalHobbies.Gymming = userProfile.UserHobbies.Gymming;

            context.SaveChanges();
        }

        public async Task<UserFilters> GetUserFilters(Guid? userProfileId)
        {
            var context = _dbContextFactory.CreateDbContext();

            var preferencesId = context.UserProfiles
                .Where(f => f.Id == userProfileId)
                .Select(s => s.UserPreferencesId)
                .FirstOrDefault();

            var hobbiesId = context.UserProfiles
                .Where(f => f.Id == userProfileId)
                .Select(s => s.UserHobbiesId)
                .FirstOrDefault();

            var preferences = context.UserPreferences
              .Where(f => f.Id == preferencesId)
              .FirstOrDefault();

            var hobbies = context.UserHobbies
                .Where(f => f.Id == hobbiesId)
                .FirstOrDefault();

            var UserFilter = new UserFilters()
            {
                UserPreferences = preferences,
                UserHobbies = hobbies            
            };

            return UserFilter;
        }
    }
}
