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
        public async Task<DogPreferencesViewModel> GetDogFiltersOnId(Guid dogFiltersRelationshipId)
        {
            var context = _dbContextFactory.CreateDbContext();

            var dogFilters = new DogPreferencesViewModel();

            var personalityId = await context.DogFiltersRelationships.Where(f => f.Id == dogFiltersRelationshipId).Select(s => s.DogPersonality).FirstOrDefaultAsync();
            var preferencesId = await context.DogFiltersRelationships.Where(f => f.Id == dogFiltersRelationshipId).Select(s => s.DogPreferences).FirstOrDefaultAsync();

            dogFilters.Personality = await context.DogFilters.Where(f => f.Id == personalityId).FirstOrDefaultAsync();
            dogFilters.Preferences = await context.DogFilters.Where(f => f.Id == preferencesId).FirstOrDefaultAsync();

            return dogFilters;
        }

        public async void UpdateDogFilters(DogPreferencesViewModel dogPreferencesViewModel)
        {
            var context = _dbContextFactory.CreateDbContext();

            var personalityOriginal = await context.DogFilters.Where(f => f.Id == dogPreferencesViewModel.Personality.Id).FirstOrDefaultAsync();
            var preferencesOriginal = await context.DogFilters.Where(f => f.Id == dogPreferencesViewModel.Preferences.Id).FirstOrDefaultAsync();

            personalityOriginal.WorksWithBoys = dogPreferencesViewModel.Personality.WorksWithBoys;
            personalityOriginal.WorksWithGirls = dogPreferencesViewModel.Personality.WorksWithGirls;
            personalityOriginal.AverageWalk = dogPreferencesViewModel.Personality.AverageWalk;
            personalityOriginal.Timid = dogPreferencesViewModel.Personality.Timid;
            personalityOriginal.Confident = dogPreferencesViewModel.Personality.Confident;
            personalityOriginal.Adaptable = dogPreferencesViewModel.Personality.Adaptable;
            personalityOriginal.Independent = dogPreferencesViewModel.Personality.Independent;
            personalityOriginal.LaidBack = dogPreferencesViewModel.Personality.LaidBack;

            preferencesOriginal.WorksWithBoys = dogPreferencesViewModel.Preferences.WorksWithBoys;
            preferencesOriginal.WorksWithGirls = dogPreferencesViewModel.Preferences.WorksWithGirls;
            preferencesOriginal.AverageWalk = dogPreferencesViewModel.Preferences.AverageWalk;
            preferencesOriginal.Timid = dogPreferencesViewModel.Preferences.Timid;
            preferencesOriginal.Confident = dogPreferencesViewModel.Preferences.Confident;
            preferencesOriginal.Adaptable = dogPreferencesViewModel.Preferences.Adaptable;
            preferencesOriginal.Independent = dogPreferencesViewModel.Preferences.Independent;
            preferencesOriginal.LaidBack = dogPreferencesViewModel.Preferences.LaidBack;

            context.SaveChanges();
        }
    }
}
