using Entities;
using Infrastructure.Repository;

namespace Infrastructure.Overviews
{
    public class ViewUserProfileOverview : IViewUserProfileOverview
    {
        private readonly IUserRepository _userRepository;
        private readonly IDogRepository _dogRepository;

        public ViewUserProfileOverview(IUserRepository userRepository, IDogRepository dogRepository)
        {
            _userRepository = userRepository;
            _dogRepository = dogRepository;
        }


        public User Profile { get; set; }
        public Dog DogProfile { get; set; }

        public async void GatherAllInfo(Guid dogId)
        {
            DogProfile = await _dogRepository.GetDogOnId(dogId);
            var ownerId = await _dogRepository.GetOwnerIdToDog(dogId);
            Profile = await _userRepository.GetMemberOnId(ownerId);
        }
    }
}
