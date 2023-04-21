using Entities;
using Infrastructure.Repository;
using Infrastructure.Service.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Dogtrick.Pages
{
    public partial class AddDog
    {
        [Inject]
        public IDogRepository _dogRepository { get; set; }
        [Inject]
        public NavigationManager _navigationManager { get; set; }

        [Parameter]
        public string MemberId { get; set; }
        public Guid ParsedMemberId { get; set; }

        public Dog NewDog = new Dog()
        {
            DogId = Guid.NewGuid(),
            Name = "",
            Age = 0,
            DogBreedId = 1,
            DogEnergyLevelId = 1,
            DogSizeId = 1,
            Allergenic = false,
        };

        public DogFilters Personality = new DogFilters()
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
        public DogFilters Preferences = new DogFilters()
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
        
        
        public AddDogViewModel AddDogViewModel = new AddDogViewModel();

        protected override async Task OnInitializedAsync()
        {
            ParsedMemberId = Guid.Parse(MemberId);
            AddDogViewModel = await _dogRepository.FillAddDogviewModelLists();
        }

        public async void SaveDog()
        {
            UserDogs userDogs = new UserDogs()
            {
                Id = Guid.NewGuid(),
                UsersDogId = ParsedMemberId,
                DogId = NewDog.DogId
            };

            DogFiltersRelationships dogRelationships = new DogFiltersRelationships() 
            { 
                Id = Guid.NewGuid(),
                DogPersonality = Personality.Id,
                DogPreferences = Preferences.Id
            };

            NewDog.DogFiltersRelationshipsId = dogRelationships.Id;

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

            _dogRepository.SaveNewDog(userDogs, Personality, Preferences, NewDog, dogRelationships, dogPictures, dogPicturesRelationships);

            _navigationManager.NavigateTo($"/MainProfile/{MemberId}");
        }
    }
}
