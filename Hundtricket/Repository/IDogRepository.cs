using Entities;
using Infrastructure.Service.ViewModels;

namespace Infrastructure.Repository
{
    public interface IDogRepository
    {
        public Task<List<DogViewModel>> GetAllDogs();
        public Task<AddDogViewModel> FillAddDogviewModelLists();
        public void SaveNewDog(UserDogs newUserDogs, DogFilters personality, DogFilters preferences, Dog newDog, DogFiltersRelationships filtersRelationships, DogPictures picture, DogPicturesRelationships dogPicturesRelationships);
    }
}
