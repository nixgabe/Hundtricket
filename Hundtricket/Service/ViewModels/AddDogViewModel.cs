using Entities;

namespace Infrastructure.Service.ViewModels
{
    public class AddDogViewModel
    {
        public List<DogBreed> Breeds { get; set; }
        public List<DogEnergyLevel> EnergyLevels { get; set; }
        public List<DogSize> Sizes { get; set; }
        public List<Gender> Genders { get; set; }
    }
}
