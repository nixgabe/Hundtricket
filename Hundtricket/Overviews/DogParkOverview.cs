using Entities;
using Infrastructure.Repository;
using Infrastructure.Service.ViewModels;

namespace Infrastructure.Overviews
{
    public class DogParkOverview : IDogParkOverview
    {
        private readonly IUserRepository _userRepository;
        private readonly IDogRepository _dogRepository;
        private readonly IUserProfileRepository _profileRepository;
        private readonly IDogFiltersRepository _dogFiltersRepository;

        public DogParkOverview(IUserRepository userRepository, IDogRepository dogRepository, 
            IUserProfileRepository userProfileRepository, IDogFiltersRepository dogFiltersRepository)
        {
            _userRepository = userRepository;
            _dogRepository = dogRepository;
            _profileRepository = userProfileRepository;
            _dogFiltersRepository = dogFiltersRepository;
        }

        public User User { get; set; }
        private List<DogProfileViewModel> AvailableProfiles { get; set; }
        public List<DogProfileViewModel> FilteredList { get; set; }
        private UserFilters UserFilters { get; set; }
        private List<UserPreferencesViewModel> AllUserFilters { get; set; }
        private List<UserPreferencesViewModel> RemainingUsersFilters { get; set; }
        public List<DogFilterViewModel> UserDogFilters { get; set; }
        public string DogName { get; set; }

        public async void GatherAllInfo(Guid memberId)
        {
            User = await _userRepository.GetMemberOnId(memberId);
            UserDogFilters = await _dogRepository.GetDogFiltersId(User.Id);
            AvailableProfiles = await _dogRepository.GetAllDogsExceptUsers(User.UserDogRelationshipsId);
            AllUserFilters = await _profileRepository.GetAllUserFilters();
            UserFilters = await _profileRepository.GetUserFilters(User);

            InitialFilter();
        }

        private void InitialFilter()
        {
            FilteredList = AvailableProfiles;
        }

        public void FilterDog()
        {
            if (DogName == null || DogName == "null")
            {
                FilteredList = AvailableProfiles;
                return;
            }

            foreach (var dog in UserDogFilters)
            {
                if (dog.DogName == DogName)
                {
                    FilteredList = AvailableProfiles.Where(filter => filter.Personality.WorksWithBoys == dog.Preferences.WorksWithBoys &&
                     filter.Personality.WorksWithGirls == dog.Preferences.WorksWithGirls && filter.Personality.Timid == dog.Preferences.Timid &&
                     filter.Personality.Confident == dog.Preferences.Confident && filter.Personality.Adaptable == dog.Preferences.Adaptable &&
                     filter.Personality.Independent == dog.Preferences.Independent && filter.Personality.LaidBack == dog.Preferences.LaidBack
                    ).ToList();

                    var ownerIds = FilteredList.Select(s => s.OwnerId).ToList();

                    RemainingUsersFilters = AllUserFilters.Where(filter => ownerIds.Contains(filter.UserId) && filter.Gender == UserFilters.UserPreferences.Gender
                    && filter.YoungestAge <= UserFilters.UserAge && filter.OldestAge >= UserFilters.UserAge)
                        .ToList();

                    ownerIds = RemainingUsersFilters.Select(f => f.UserId).ToList();

                    FilteredList = FilteredList.Where(filter => ownerIds.Contains(filter.OwnerId))
                        .ToList();

                    break;
                }
            }
        }
    }
}
