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

        public async Task<List<string>> GetPicturesOnId(Guid dogId)
        {
            var context = _dbContextFactory.CreateDbContext();

            var id = context.DogPicturesRelationships
                .Where(f => f.Id == dogId)
                .Select(f => f.DogPicturesId)
                .FirstOrDefault();

            return context.DogPictures
                .Where(f => f.DogPicturesId == id)
                .Select(f => f.Photo)
                .ToList();
        }
    }
}
