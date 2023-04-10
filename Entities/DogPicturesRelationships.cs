namespace Entities
{
    public class DogPicturesRelationships
    {
        public Guid Id { get; set; }
        public Guid DogPicturesId { get; set; }     
        
        public ICollection<DogPictures> DogPictures { get; set; }
    }
}
