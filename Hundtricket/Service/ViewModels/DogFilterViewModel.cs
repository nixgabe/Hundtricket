using Entities;

namespace Infrastructure.Service.ViewModels
{
    public class DogFilterViewModel
    {
        public string DogName { get; set; }
        public DogPersonalityViewModel Personality { get; set; }
        public DogPreferencesViewModel Preferences { get; set; }

    }
}
