using Entities;
using Infrastructure.Service.ViewModels;

namespace Infrastructure.Overviews
{
    public interface IDogProfileOverview
    {
        public Dog Dog { get; set; }
        public DogFilterViewModel DogPreferences { get; set; }
        public AddDogViewModel DogViewModel { get; set; }
        public bool EditDog { get; set; }

        public void GatherAllInfo(Guid dogId);
        public void EditDogButton();
        public void SaveDogChangesButton(Guid dogId);
    }
}
