using Entities;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Components;

namespace Dogtrick.Pages
{
    public partial class ViewUserProfile
    {
        [Inject]
        public IUserRepository _userRepository { get; set; }
        [Inject]
        public IDogRepository _dogRepository { get; set; }

        [Parameter]
        public string DogId { get; set; }
        private Guid ParsedDogId { get; set; }
        public User Profile { get; set; }
        public Dog DogProfile { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ParsedDogId = Guid.Parse(DogId);
            DogProfile = await _dogRepository.GetDogOnId(ParsedDogId);
            //Get OwnerId to dog, which then is used to find the profile of the owner
            var ownerId = await _dogRepository.GetOwnerIdToDog(ParsedDogId);
            Profile = await _userRepository.GetMemberOnId(ownerId);
        }
    }
}
