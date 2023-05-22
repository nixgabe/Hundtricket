using Entities;
using Hundtricket.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class DogPicturesRepository : IDogPicturesRepository
    {
        private readonly IDbContextFactory<HundtricketContext> _dbContextFactory;        

        public DogPicturesRepository(IDbContextFactory<HundtricketContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public Task<string> GetFirstPicOnId(Guid dogId)
        {
            var context = _dbContextFactory.CreateDbContext();

            var id = context.DogPicturesRelationships
                .Where(f => f.Id == dogId)
                .Select(f => f.DogPicturesId)
                .FirstOrDefault();

            return context.DogPictures.Where(f => f.DogPicturesId == id)
                .Select(f => f.Photo).FirstOrDefaultAsync();
        }

        public async Task<List<string>> GetPicturesOnId(Guid picturesId)
        {
            var context = _dbContextFactory.CreateDbContext();

            var id = context.DogPicturesRelationships
                .Where(f => f.Id == picturesId)
                .Select(f => f.DogPicturesId)
                .FirstOrDefault();

            return context.DogPictures
                .Where(f => f.DogPicturesId == id)
                .Select(f => f.Photo)
                .ToList();
        }

        public async Task<Guid> GetRelationshipsOnId(Guid relationshipId)
        {
            var context = _dbContextFactory.CreateDbContext();

            return context.DogPicturesRelationships.Where(f => f.Id == relationshipId).Select(s => s.DogPicturesId).FirstOrDefault();
        }

        public async Task UploadPicture(List<DogPictures> pictures)
        {
            var context = _dbContextFactory.CreateDbContext();

            foreach (var pic in pictures)
            {
                context.DogPictures.Add(pic);
            }

            context.SaveChanges();           

        }
    }
}
