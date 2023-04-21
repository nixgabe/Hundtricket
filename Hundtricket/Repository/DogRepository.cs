using Entities;
using Hundtricket.Context;
using Infrastructure.Service.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class DogRepository : IDogRepository
    {
        private readonly IDbContextFactory<HundtricketContext> _dbContextFactory;

        public DogRepository(IDbContextFactory<HundtricketContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<List<DogViewModel>> GetAllDogs()
        {
            var context = _dbContextFactory.CreateDbContext();

            return context.Dogs
                .Include(f => f.DogBreed)
                .Select(x => new DogViewModel()
                {
                    Id = x.DogId,
                    Name = x.Name,
                    Age = x.Age,
                    Breed = x.DogBreed.Breed,
                    PicturesId = x.DogPicturesRelationshipsId
                })
                .ToList();
        }

        public async Task<AddDogViewModel> FillAddDogviewModelLists()
        {
            var context = _dbContextFactory.CreateDbContext();
            var list = new AddDogViewModel();

            list.Breeds = context.DogBreeds.Select(x => new DogBreed()
            {
                Id = x.Id,
                Breed = x.Breed
            }).ToList();

            list.EnergyLevels = context.DogEnergyLevels.Select(x => new DogEnergyLevel()
            {
                Id = x.Id,
                EnergyLevel = x.EnergyLevel,
            }).ToList();

            list.Sizes = context.DogSizes.Select(x => new DogSize()
            {
                Id = x.Id,
                Size = x.Size
            }).ToList();

            return list;
        }

        public void SaveNewDog(UserDogs userDog, DogFilters personality, DogFilters preferences, Dog newDog, DogFiltersRelationships filtersRelationships, DogPictures dogPictures, DogPicturesRelationships dogPicturesRelationships)
        {
            var context = _dbContextFactory.CreateDbContext();

            context.UserDogs.Add(userDog);
            context.DogFilters.Add(personality);
            context.DogFilters.Add(preferences);
            context.DogFiltersRelationships.Add(filtersRelationships);
            context.DogPictures.Add(dogPictures);
            context.DogPicturesRelationships.Add(dogPicturesRelationships);
            context.Dogs.Add(newDog);
            context.SaveChanges();
        }
    }
}
