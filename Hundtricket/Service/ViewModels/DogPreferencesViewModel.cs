using Entities;

namespace Infrastructure.Service.ViewModels
{
    public class DogPreferencesViewModel
    {
        public DogFilters Personality { get; set; }
        public DogFilters Preferences { get; set; }

    }
}
