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

        public DogFilters Personality { get; set; }
        public DogFilters Preferences { get; set; }
        public UserDogs NewUserDogs { get; set; }
        
        public AddDogViewModel AddDogViewModel = new AddDogViewModel();

        protected override async Task OnInitializedAsync()
        {
            ParsedMemberId = Guid.Parse(MemberId);
            AddDogViewModel = await _dogRepository.FillDogviewModelLists();
        }

        public void SaveDog()
        {
            NewUserDogs.Id = Guid.NewGuid();
            NewUserDogs.UsersDogId = ParsedMemberId;
            NewUserDogs.DogId = NewDog.DogId;
        }
    }
}
