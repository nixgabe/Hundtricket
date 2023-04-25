using Entities;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Components;

namespace Dogtrick.Pages
{
    public partial class EditProfile
    {
        [Inject]
        public IUserRepository _userRepository { get; set; }
        [Inject]
        public IUserProfileRepository _userProfileRepository { get; set; }
        [Inject]
        public NavigationManager _navigationManager { get; set; }

        [Parameter]
        public string MemberId { get; set; }
        private Guid ParsedMemberId { get; set; }

        public User User { get; set; }
        public UserProfile UserProfile { get; set; }
        public UserPreferences Preferences { get; set; }
        public UserHobbies Hobbies { get; set; }
        public List<Gender> Genders { get; set; }



        protected override async Task OnInitializedAsync()
        {
            ParsedMemberId = Guid.Parse(MemberId);
            User = await _userRepository.GetMemberOnId(ParsedMemberId);
            UserProfile = await _userProfileRepository.GetUserProfileOnMemberId((Guid)User.UserProfileId);
            Hobbies = UserProfile.UserHobbies;
            Genders = await _userRepository.GetGendersList();
        }

        public async void SaveChanges()
        {
            _userRepository.UpdateUser(User);
            _userProfileRepository.UpdateUserProfile(UserProfile);
            _navigationManager.NavigateTo($"/MainProfile/{User.Id}");
        }
    }
}
