using Entities;
using Infrastructure.Repository;
using Infrastructure.Service.ViewModels;

namespace Infrastructure.Overviews
{
    public class DogProfileOverview : IDogProfileOverview
    {
        private readonly IDogRepository _dogRepository;
        private readonly IDogFiltersRepository _dogFiltersRepository;

        public DogProfileOverview(IDogRepository dogRepository, IDogFiltersRepository dogFiltersRepository)
        {
            _dogRepository = dogRepository;
            _dogFiltersRepository = dogFiltersRepository;
        }

        public Dog Dog { get; set; }
        public DogFilterViewModel DogPreferences { get; set; }
        public AddDogViewModel DogViewModel { get; set; }
        public bool EditDog { get; set; } = false;

        public async void GatherAllInfo(Guid dogId)
        {
            Dog = await _dogRepository.GetDogOnId(dogId);
            DogPreferences = await _dogFiltersRepository.GetDogFiltersOnId(Dog);
            DogViewModel = await _dogRepository.FillAddDogviewModelLists();
        }

        public void EditDogButton()
        {
            EditDog = true;
        }

        public async void SaveDogChangesButton(Guid dogId)
        {
            _dogRepository.UpdateDog(Dog);
            _dogFiltersRepository.UpdateDogFilters(DogPreferences, dogId);

            EditDog = false;
        }

    }
}
