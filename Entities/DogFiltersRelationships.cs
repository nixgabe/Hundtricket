namespace Entities
{
    public class DogFiltersRelationships
    {
        public Guid Id { get; set; }
        public Guid DogPersonality { get; set; }
        public Guid DogPreferences { get; set; }

        public ICollection<DogFilters> DogFilters { get; set; }
    }
}
