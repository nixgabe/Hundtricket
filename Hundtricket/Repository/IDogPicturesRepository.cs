using Entities;

namespace Infrastructure.Repository
{
    public interface IDogPicturesRepository
    {
        public Task<List<string>> GetPicturesOnId(Guid dogId);

        public Task UploadPicture(List<DogPictures> picture);

        public Task<Guid> GetRelationshipsOnId(Guid relationshipId);

        public Task<string> GetFirstPicOnId(Guid dogId);
    }
}
