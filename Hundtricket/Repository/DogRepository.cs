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

        public async Task<AddDogViewModel> FillDogviewModelLists()
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
    }
}
