namespace Infrastructure.Repository
{
    public interface IDogPicturesRepository
    {
        public Task<List<string>> GetPicturesOnId(Guid dogId);
    }
}
