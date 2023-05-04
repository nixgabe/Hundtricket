using Entities;
using Hundtricket.Context;
using Infrastructure.Service.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class DogFiltersRepository : IDogFiltersRepository
    {

        private readonly IDbContextFactory<HundtricketContext> _dbContextFactory;

        public DogFiltersRepository(IDbContextFactory<HundtricketContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }
        public async Task<DogFilterViewModel> GetDogFiltersOnId(Dog dog)
        {
            var context = _dbContextFactory.CreateDbContext();

            var dogFilters = new DogFilterViewModel();

#pragma warning disable CS8601 // Possible null reference assignment.
            dogFilters.Personality = context.DogPersonality.Where(f => f.Id == dog.DogPersonalityId)
                .Select(f => new DogPersonalityViewModel()
                {
                    WorksWithBoys = f.WorksWithBoys,
                    WorksWithGirls = f.WorksWithGirls,
                    Timid = f.Timid,
                    Confident = f.Confident,
                    Adaptable = f.Adaptable,
                    Independent = f.Independent,
                    LaidBack = f.LaidBack
                })
                .FirstOrDefault();

            dogFilters.Preferences = context.DogPreferences.Where(f => f.Id == dog.DogPreferencesId)
                .Select(f => new DogPreferencesViewModel()
                {
                    WorksWithBoys = f.WorksWithBoys,
                    WorksWithGirls = f.WorksWithGirls,
                    Timid = f.Timid,
                    Confident = f.Confident,
                    Adaptable = f.Adaptable,
                    Independent = f.Independent,
                    LaidBack = f.LaidBack
                })
                .FirstOrDefault();
#pragma warning restore CS8601 // Possible null reference assignment.

            return dogFilters;
        }

        public async void UpdateDogFilters(DogFilterViewModel dogPreferencesViewModel, Guid dogId)
        {
            var context = _dbContextFactory.CreateDbContext();

            var preferencesOriginal = await context.Dogs
                .Include(s => s.DogPreferences)
                .Where(f => f.DogId == dogId).Select(f => f.DogPreferences)
                .FirstOrDefaultAsync();

            var personalityOriginal = await context.Dogs
                .Include(s => s.DogPersonality)
                .Where(f => f.DogId == dogId).Select(f => f.DogPersonality)
                .FirstOrDefaultAsync();

            //var personalityOriginal = await context.DogPersonality.Where(f => f.Id == dogPreferencesViewModel.Personality.Id).FirstOrDefaultAsync();
            //var preferencesOriginal = await context.DogPreferences.Where(f => f.Id == dogPreferencesViewModel.Preferences.Id).FirstOrDefaultAsync();

            personalityOriginal.WorksWithBoys = dogPreferencesViewModel.Personality.WorksWithBoys;
            personalityOriginal.WorksWithGirls = dogPreferencesViewModel.Personality.WorksWithGirls;
            //personalityOriginal.AverageWalk = dogPreferencesViewModel.Personality.AverageWalk;
            personalityOriginal.Timid = dogPreferencesViewModel.Personality.Timid;
            personalityOriginal.Confident = dogPreferencesViewModel.Personality.Confident;
            personalityOriginal.Adaptable = dogPreferencesViewModel.Personality.Adaptable;
            personalityOriginal.Independent = dogPreferencesViewModel.Personality.Independent;
            personalityOriginal.LaidBack = dogPreferencesViewModel.Personality.LaidBack;

            preferencesOriginal.WorksWithBoys = dogPreferencesViewModel.Preferences.WorksWithBoys;
            preferencesOriginal.WorksWithGirls = dogPreferencesViewModel.Preferences.WorksWithGirls;
            //preferencesOriginal.AverageWalk = dogPreferencesViewModel.Preferences.AverageWalk;
            preferencesOriginal.Timid = dogPreferencesViewModel.Preferences.Timid;
            preferencesOriginal.Confident = dogPreferencesViewModel.Preferences.Confident;
            preferencesOriginal.Adaptable = dogPreferencesViewModel.Preferences.Adaptable;
            preferencesOriginal.Independent = dogPreferencesViewModel.Preferences.Independent;
            preferencesOriginal.LaidBack = dogPreferencesViewModel.Preferences.LaidBack;

            context.SaveChanges();
        }

    }
}
