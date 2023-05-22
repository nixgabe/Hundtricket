using Entities;
using Infrastructure.Repository;

namespace Infrastructure.Overviews
{
    public class EditProfileOverview : IEditProfileOverview
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserProfileRepository _userProfileRepository;

        public EditProfileOverview(IUserRepository userRepository, IUserProfileRepository userProfileRepository)
        {
            _userRepository = userRepository;
            _userProfileRepository = userProfileRepository;
        }

        public User User { get; set; }
        public UserProfile UserProfile { get; set; }

        public UserPreferences UserPreferencesTemp { get; set; } = new UserPreferences();
        public int GenderIdTemp { get; set; } = 0;
        public int PreferenceIdTemp { get; set; } = 0;
        public List<Gender> Genders { get; set; }

        public async Task GatherAllInfo(Guid memberId)
        {
            User = await _userRepository.GetMemberOnId(memberId);
            UserProfile = await _userProfileRepository.GetUserProfileOnMemberId((Guid)User.UserProfileId);
            Genders = await _userRepository.GetGendersList();

        }

        public async void SaveChanges()
        {
            UserProfile.UserPreferences.GenderId = PreferenceIdTemp;
            UserProfile.GenderId = GenderIdTemp;
            _userRepository.UpdateUser(User);
            _userProfileRepository.UpdateUserProfile(UserProfile);
        }
    }
}
