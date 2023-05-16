using Entities;
using Infrastructure.Repository;
using Infrastructure.Service.ViewModels;

namespace Infrastructure.Overviews
{
    public class AddDogOverview : IAddDogOverview
    {
        private readonly IDogRepository _dogRepository;

        public Dog NewDog { get; set; }
        public DogPersonality NewDogPersonality { get; set; }
        public DogPreferences NewDogPreferences { get; set; }
        public AddDogViewModel NewDogViewModel { get; set; }

        public AddDogOverview(IDogRepository dogRepository)
        {
            _dogRepository = dogRepository;
        }

        public async Task CreateNewDogTemplates()
        {
            Dog newDog = new Dog()
            {
                DogId = Guid.NewGuid(),
                Name = "",
                Age = 0,
                DogBreedId = 1,
                DogEnergyLevelId = 1,
                DogSizeId = 1,
                Allergenic = false,
            };

            DogPersonality newDogPersonality = new DogPersonality()
            {
                Id = Guid.NewGuid(),
                AverageWalk = 0,
                WorksWithBoys = false,
                WorksWithGirls = false,
                Timid = false,
                Confident = false,
                Adaptable = false,
                Independent = false,
                LaidBack = false
            };

            DogPreferences newDogPreferences = new DogPreferences()
            {
                Id = Guid.NewGuid(),
                AverageWalk = 0,
                WorksWithBoys = false,
                WorksWithGirls = false,
                Timid = false,
                Confident = false,
                Adaptable = false,
                Independent = false,
                LaidBack = false
            };            

            NewDog = newDog;
            NewDogPersonality = newDogPersonality;
            NewDogPreferences = newDogPreferences;
            NewDogViewModel = await _dogRepository.FillAddDogviewModelLists();
        }

        public async void SaveDog(Guid memberId)
        {
            UserDogs userDogs = new UserDogs()
            {
                Id = Guid.NewGuid(),
                UsersDogId = memberId,
                DogId = NewDog.DogId
            };

            DogPictures dogPictures = new DogPictures()
            {
                Id = Guid.NewGuid(),
                DogPicturesId = Guid.NewGuid(),
                Photo = "Pic"

            };

            DogPicturesRelationships dogPicturesRelationships = new DogPicturesRelationships()
            {
                Id = Guid.NewGuid(),
                DogPicturesId = dogPictures.DogPicturesId
            };

            NewDog.DogPicturesRelationshipsId = dogPicturesRelationships.Id;
            NewDog.DogPersonalityId = NewDogPersonality.Id;
            NewDog.DogPreferencesId = NewDogPreferences.Id;

            _dogRepository.SaveNewDog(userDogs, NewDogPersonality, NewDogPreferences, NewDog, dogPictures, dogPicturesRelationships, memberId);
        }
    }
}
