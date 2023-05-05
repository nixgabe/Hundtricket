using Entities;
using Infrastructure.Repository;
using Infrastructure.Service.ViewModels;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Dogtrick.Pages
{
    public partial class DogPark
    {
        [Inject]
        public IUserRepository _userRepository { get; set; }
        [Inject]
        public IDogRepository _dogRepository { get; set; }
        [Inject]
        public IUserProfileRepository _profileRepository { get; set; }
        [Inject]
        public IDogFiltersRepository _filtersRepository { get; set; }
        [Inject]
        public NavigationManager _navigationManager { get; set; }

        [Parameter]
        public string MemberId { get; set; }
        private Guid ParsedMemberId { get; set; }
        public User User { get; set; }
        List<DogProfileViewModel> AvailableProfiles { get; set; }
        List<DogProfileViewModel> FilteredList { get; set; }
        UserFilters UserFilters { get; set; }
        List<UserPreferencesViewModel> AllUserFilters { get; set; }
        List<UserPreferencesViewModel> RemainingUsersFilters { get; set; }
        List<DogFilterViewModel> UserDogFilters { get; set; }
        public string DogName { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ParsedMemberId = Guid.Parse(MemberId);
            User = await _userRepository.GetMemberOnId(ParsedMemberId);
            UserDogFilters = await _dogRepository.GetDogFiltersId(User.Id);
            AvailableProfiles = await _dogRepository.GetAllDogsExceptUsers(User.UserDogRelationshipsId);
            AllUserFilters = await _profileRepository.GetAllUserFilters();
            UserFilters = await _profileRepository.GetUserFilters(User);
            
            InitialFilter();
        }

        public void InitialFilter()
        {
            FilteredList = AvailableProfiles;
        }

        //Can definitely be done prettier
        public void FilterOnDog()
        {
            if(DogName == null || DogName == "null")
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
        
        public void ViewMemberProfile(Guid profileId)
        {
            string dogId = profileId.ToString();
            _navigationManager.NavigateTo($"/ViewUserProfile/{dogId}");
        }
    }
}
