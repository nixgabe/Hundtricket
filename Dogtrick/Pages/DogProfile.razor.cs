using Entities;
using Infrastructure.Repository;
using Infrastructure.Service.ViewModels;
using Microsoft.AspNetCore.Components;
using System.Security.Permissions;

namespace Dogtrick.Pages
{
    public partial class DogProfile
    {
        [Inject]
        public IDogRepository _dogRepository { get; set; }
        [Inject]
        public IDogFiltersRepository _dogFiltersRepository { get; set; }
        [Inject]
        public NavigationManager _navigationManager { get; set; }

        [Parameter]
        public string DogId { get; set; }
        private Guid ParsedDogId { get; set; }
        public Dog Dog { get; set; }
        public DogPreferencesViewModel DogPreferences { get; set; }
        public AddDogViewModel DogViewModel { get; set; }

        public bool EditDog = false;


        protected override async Task OnInitializedAsync()
        {
            ParsedDogId = Guid.Parse(DogId);
            Dog = await _dogRepository.GetDogOnId(ParsedDogId);
            DogPreferences = await _dogFiltersRepository.GetDogFiltersOnId(Dog.DogFiltersRelationshipsId);
            DogViewModel = await _dogRepository.FillAddDogviewModelLists();
        }

        public void EditDogButton()
        {
            EditDog = true;
        }

        public async void SaveDogChangesButton()
        {
            _dogRepository.UpdateDog(Dog);
            _dogFiltersRepository.UpdateDogFilters(DogPreferences);

            EditDog = false;            
        }
    }
}
