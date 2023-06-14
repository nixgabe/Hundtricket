using Entities;
using Infrastructure.Repository;

namespace Infrastructure.Overviews
{
    public class ViewUserProfileOverview : IViewUserProfileOverview
    {
        private readonly IUserRepository _userRepository;
        private readonly IDogRepository _dogRepository;
        private readonly IDogPicturesRepository _picturesRepository;

        public ViewUserProfileOverview(IUserRepository userRepository, IDogRepository dogRepository, IDogPicturesRepository dogPicturesRepository)
        {
            _userRepository = userRepository;
            _dogRepository = dogRepository;
            _picturesRepository = dogPicturesRepository;
        }


        public User Profile { get; set; }
        public Dog DogProfile { get; set; }
        public string DogPicture { get; set; }

        public async Task GatherAllInfo(Guid dogId)
        {
            DogProfile =  await _dogRepository.GetDogOnId(dogId);
            var ownerId = await _dogRepository.GetOwnerIdToDog(dogId);
            Profile = await _userRepository.GetMemberOnId(ownerId);
            DogPicture = await _picturesRepository.GetFirstPicOnId(DogProfile.DogPicturesRelationshipsId);
        }
    }
}
