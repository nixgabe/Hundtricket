using Entities;
using Infrastructure.Service.ViewModels;

namespace Infrastructure.Overviews
{
    public interface IAddDogOverview
    {
        public Dog NewDog { get; set; }
        public DogPreferences NewDogPreferences { get; set; }
        public DogPersonality NewDogPersonality { get; set; }
        public AddDogViewModel NewDogViewModel { get; set; }
        public Task CreateNewDogTemplates();
        public void SaveDog(Guid memberId);
    }
}
