using Entities;
using Infrastructure.Service.ViewModels;

namespace Infrastructure.Repository
{
    public interface IDogRepository
    {
        public Task<List<DogViewModel>> GetAllDogs();
        public Task<AddDogViewModel> FillAddDogviewModelLists();
        public void SaveNewDog(UserDogs newUserDogs, DogPersonality personality, DogPreferences preferences, Dog newDog, DogPictures picture, 
            DogPicturesRelationships dogPicturesRelationships, Guid memberId);
        public Task<List<DogViewModel>> GetMemberDogsOnId(Guid MemberId);        
        public void UpdateDog(Dog updatedDog);
        public Task<Dog> GetDogOnId(Guid dogId);
        public Task<List<DogProfileViewModel>> GetAllDogsExceptUsers(Guid? userDogRelationshipsId);
        public Task<List<DogFilterViewModel>> GetDogFiltersId(Guid userId);        
    }
}
