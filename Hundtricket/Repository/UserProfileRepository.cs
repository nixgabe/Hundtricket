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

        public async Task<UserFilters> GetUserFilters(User user)
        {
            var context = _dbContextFactory.CreateDbContext();

            var preferencesId = context.UserProfiles
                .Where(f => f.Id == user.UserProfileId)
                .Select(s => s.UserPreferencesId)
                .FirstOrDefault();

            var hobbiesId = context.UserProfiles
                .Where(f => f.Id == user.UserProfileId)
                .Select(s => s.UserHobbiesId)
                .FirstOrDefault();

            var preferences = context.UserPreferences
              .Where(f => f.Id == preferencesId)
              .Select(s => new UserPreferencesViewModel()
              {
                  Gender = s.Gender,
                  YoungestAge = s.YoungestAge,
                  OldestAge = s.OldestAge
              })
              .FirstOrDefault();

            var hobbies = context.UserHobbies
                .Where(f => f.Id == hobbiesId)
                .FirstOrDefault();

            var UserFilter = new UserFilters()
            {
                UserAge = user.Age,
                UserPreferences = preferences,
                UserHobbies = hobbies            
            };

            return UserFilter;
        }

        public async Task<List<UserPreferencesViewModel>> GetAllUserFilters()
        {
            var context = _dbContextFactory.CreateDbContext();
            var list = context.UserPreferences
            .Select(s => new UserPreferencesViewModel()
            {
                FilterId = s.Id,
                Gender = s.Gender,
                YoungestAge = s.YoungestAge,
                OldestAge = s.OldestAge
            })
            .ToList();

            var users = context.Users
                .Include(f => f.UserProfile)
                .Select(s => new User()
                {
                    Id = s.Id,
                    UserProfile = s.UserProfile
                }).ToList();

            foreach (var filter in list)
            {
                filter.UserId = users.Where(f => f.UserProfile.UserPreferencesId == filter.FilterId).Select(s => s.Id).FirstOrDefault();
            }

            return list;
        }
    }
}
