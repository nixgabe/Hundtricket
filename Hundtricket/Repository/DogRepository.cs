using Entities;
using Hundtricket.Context;
using Infrastructure.Service.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class DogRepository : IDogRepository
    {
        private readonly IDbContextFactory<HundtricketContext> _dbContextFactory;
        private readonly IDogFiltersRepository _dogFiltersRepository;

        public DogRepository(IDbContextFactory<HundtricketContext> dbContextFactory, IDogFiltersRepository dogFiltersRepository)
        {
            _dbContextFactory = dbContextFactory;
            _dogFiltersRepository = dogFiltersRepository;
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

        public void SaveNewDog(UserDogs userDog, DogPersonality personality, DogPreferences preferences, Dog newDog, 
            DogPictures dogPictures, DogPicturesRelationships dogPicturesRelationships, Guid memberId)
        {
            var context = _dbContextFactory.CreateDbContext();

            var userRelationships = new UserDogRelationships()
            {
                Id = Guid.NewGuid(),
                UsersDogId = userDog.Id,
            };

            context.UserDogs.Add(userDog);
            context.Dogs.Add(newDog);
            context.DogPersonality.Add(personality);
            context.DogPreferences.Add(preferences);            
            context.DogPictures.Add(dogPictures);
            context.DogPicturesRelationships.Add(dogPicturesRelationships);            ;
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

        public async Task<List<DogProfileViewModel>> GetAllDogsExceptUsers(Guid? userDogRelationshipsId)
        {
            var context = _dbContextFactory.CreateDbContext();
            var availableProfiles = new List<AvailableProfilesViewModel>();
            var dogList = new List<DogProfileViewModel>();

            var relationshipsId = context.UserDogRelationships
                .Where(f => f.Id == userDogRelationshipsId)
                .Select(f => f.UsersDogId).FirstOrDefault();
            
            var ownerId = context.UserDogs
                .Where(f => f.Id == relationshipsId)
                .Select(s => s.UsersDogId).FirstOrDefault();

            var userRelationships = context.UserDogs
                .Where(f => f.UsersDogId != ownerId)
                .Select(s => new UserDogs()
                {
                    UsersDogId = s.UsersDogId,
                    DogId = s.DogId,
                }
                ).ToList();

            var userDogIdList = context.UserDogs
                .Where(f => f.UsersDogId == ownerId)
                .Select(f => f.DogId).ToList();

            dogList = context.Dogs
                .Include(f => f.DogBreed)
                .Include (n => n.Gender)
                .Include(m => m.DogSize)
                .Include(o => o.DogEnergyLevel)
                .Include(p => p.DogPreferences) 
                .Include(n => n.DogPersonality)
                .Select(dog => new DogProfileViewModel()
                {
                    Id = dog.DogId,
                    Name = dog.Name,
                    Age = dog.Age,
                    Gender = dog.Gender.GenderOption,
                    DogBreed = dog.DogBreed.Breed,   
                    DogEnergyLevel = dog.DogEnergyLevel.EnergyLevel,
                    DogSize = dog.DogSize.Size,
                    Preferences = dog.DogPreferences,
                    Personality = dog.DogPersonality,
                    //This one messes it up because it's the signed in users id, and not the id of the actual owner
                    //OwnerId = ownerId
                }).Where(f => !userDogIdList.Contains(f.Id)).ToList();

            //Can be done nicer
            foreach(var dog in dogList)
            {
                dog.OwnerId = userRelationships.Where(f => f.DogId == dog.Id).Select(f => f.UsersDogId).FirstOrDefault();
            }

            return dogList;
        }

        public async Task<List<DogFilterViewModel>> GetDogFiltersId(Guid userId)
        {
            var context = _dbContextFactory.CreateDbContext();
            var dogPreferencesViewModelList = new List<DogFilterViewModel>();

            var dogIdList = context.UserDogs
                .Where(f => f.UsersDogId == userId)
                .Select(s => s.DogId)
                .ToList();

            var preferencesIdList = context.Dogs
                .Where(f => dogIdList.Contains(f.DogId))
                .Select(s => s.DogPreferencesId)
                .ToList();

            foreach (var id in preferencesIdList)
            {
                var dogName = context.Dogs
                    .Where(s => s.DogPreferencesId == id)
                    .Select(f => f.Name)
                    .FirstOrDefault();

                var dogPreferencesTemp = context.DogPreferences
                    .Where(f => f.Id == id)
                    .FirstOrDefault();

                var dogPreferences = new DogPreferencesViewModel()
                {
                    WorksWithBoys = dogPreferencesTemp.WorksWithBoys,
                    WorksWithGirls = dogPreferencesTemp.WorksWithGirls,
                    Timid = dogPreferencesTemp.Timid,
                    Confident = dogPreferencesTemp.Confident,
                    Adaptable = dogPreferencesTemp.Adaptable,
                    Independent = dogPreferencesTemp.Independent,
                    LaidBack = dogPreferencesTemp.LaidBack,
                };

                var item = new DogFilterViewModel();
                item.DogName = dogName;
                item.Preferences = dogPreferences;

                dogPreferencesViewModelList.Add(item);
            }

            return dogPreferencesViewModelList;
        }
    }
}
