namespace Entities
{
    public class Dog
    {
        public Guid DogId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int GenderId { get; set; }
        public string? About { get; set; }
        public int DogBreedId { get; set; }
        public int DogSizeId { get; set; }
        public int DogEnergyLevelId { get; set; }
        public bool Allergenic { get; set; } = false;
        public Guid DogPicturesRelationshipsId { get; set; }
        public Guid DogPersonalityId { get; set; }
        public Guid DogPreferencesId { get; set; }

        public virtual DogBreed DogBreed { get; set; }
        public virtual DogEnergyLevel DogEnergyLevel { get; set; }
        public virtual DogSize DogSize { get; set; }
        public virtual DogPicturesRelationships DogPicturesRelationships { get; set; }
        public virtual DogPersonality DogPersonality { get; set; }
        public virtual DogPreferences DogPreferences { get; set; }
        public virtual Gender Gender { get; set; }
        
    }
}