using Entities;

namespace Infrastructure.Service.ViewModels
{
    public class DogProfileViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string? About { get; set; }
        public string DogBreed { get; set; }
        public string DogSize { get; set; }
        public string DogEnergyLevel { get; set; }
        public bool Allergenic { get; set; } = false;
        public Guid FiltersId { get; set; } 
        public DogPersonality Personality { get; set; }
        public DogPreferences Preferences { get; set; }
        public Guid OwnerId { get; set; }
    }
}
