using Entities;
using Hundtricket.Context;
using Infrastructure.Service.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

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

            list.Genders = context.Genders.Select(x => new Gender()
            {
                Id = x.Id,
                GenderOption = x.GenderOption,
            }).ToList();

            return list;
        }

        public void SaveNewDog(UserDogs userDog, DogFilters personality, DogFilters preferences, Dog newDog, DogFiltersRelationships filtersRelationships, 
            DogPictures dogPictures, DogPicturesRelationships dogPicturesRelationships, Guid memberId)
        {
            var context = _dbContextFactory.CreateDbContext();

            var userRelationships = new UserDogRelationships()
            {
                Id = Guid.NewGuid(),
                UsersDogId = userDog.Id,
            };

            context.UserDogs.Add(userDog);
            context.DogFilters.Add(personality);
            context.DogFilters.Add(preferences);
            context.DogFiltersRelationships.Add(filtersRelationships);
            context.DogPictures.Add(dogPictures);
            context.DogPicturesRelationships.Add(dogPicturesRelationships);
            context.Dogs.Add(newDog);
            context.UserDogRelationships.Add(userRelationships);

            var user = context.Users.Where(x => x.Id == memberId).FirstOrDefault();

            user.UserDogRelationshipsId = userRelationships.Id;

            context.SaveChanges();
        }

        public async Task<List<DogViewModel>> GetMemberDogsOnId(Guid MemberId)
        {
            var context = _dbContextFactory.CreateDbContext();

            var dogList = context.UserDogs
                .Where(f => f.UsersDogId == MemberId)
                .Select(s => s.DogId)
                .ToList();

            List<DogViewModel> modelList = new List<DogViewModel>();

            //Can probably be done in one line in linq
            foreach (var id in dogList)
            {
                var dog = context.Dogs
                    .Include(f => f.DogBreed)
                    .Where(f => f.DogId == id)
                    .Select(x => new DogViewModel()
                    {
                        Id = x.DogId,
                        Name = x.Name,
                        Age = x.Age,
                        Breed = x.DogBreed.Breed,
                        PicturesId = x.DogPicturesRelationshipsId
                    })
                    .FirstOrDefault();

                modelList.Add(dog);
            }

            return modelList;
        }

        public void UpdateDog(Dog updatedDog)
        {
            var context = _dbContextFactory.CreateDbContext();
            var original = context.Dogs
                .Where(f => f.DogId == updatedDog.DogId)
                .FirstOrDefault();

            original.Name = updatedDog.Name;
            original.Age = updatedDog.Age;
            original.GenderId = updatedDog.GenderId;
            original.About = updatedDog.About;
            original.DogBreedId = updatedDog.DogBreedId;
            original.DogSizeId = updatedDog.DogSizeId;
            original.DogEnergyLevelId = updatedDog.DogEnergyLevelId;
            original.Allergenic = updatedDog.Allergenic;
            
            context.SaveChanges();
        }

        public async Task<Dog> GetDogOnId(Guid dogId)
        {
            var context = _dbContextFactory.CreateDbContext();

            return await context.Dogs.Where(f => f.DogId == dogId)
                .Include(s => s.DogBreed)
                .Include(n => n.DogSize)
                .Include(m => m.DogEnergyLevel)
                .Include(o => o.Gender)
                .FirstOrDefaultAsync();
        }

        public async Task<List<DogViewModel>> GetAllDogsExceptUsers(Guid? userDogRelationshipsId)
        {
            var context = _dbContextFactory.CreateDbContext();
            var dogList = new List<DogViewModel>();

            var relationshipsId = context.UserDogRelationships
                .Where(f => f.Id == userDogRelationshipsId)
                .Select(f => f.UsersDogId).FirstOrDefault();
            
            var ownerId = context.UserDogs
                .Where(f => f.Id == relationshipsId)
                .Select(s => s.UsersDogId).FirstOrDefault();

            var userDogIdList = context.UserDogs
                .Where(f => f.UsersDogId == ownerId)
                .Select(f => f.DogId).ToList();


            //Probably needs updating since it's not taking any filters with itself yet. But different issue different task
            dogList = context.Dogs
                .Include(f => f.DogBreed)
                .Select(dog => new DogViewModel()
            {
                Id = dog.DogId,
                Name = dog.Name,
                Age = dog.Age,
                Breed = dog.DogBreed.Breed,
                PicturesId = dog.DogPicturesRelationshipsId
            }).Where(f => !userDogIdList.Contains(f.Id)).ToList();   

            return dogList;
        }
    }
}
