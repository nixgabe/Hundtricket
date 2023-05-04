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

        [Parameter]
        public string MemberId { get; set; }
        private Guid ParsedMemberId { get; set; }
        public User User { get; set; }
        List<DogProfileViewModel> Dogs { get; set; }
        List<DogProfileViewModel> FilteredDogs { get; set; }
        UserFilters UserFilters { get; set; }
        List<DogFilterViewModel> UserDogFilters { get; set; }
        public string DogName { get; set; }

        //What I need, user and their preferences which I should get from just User profile. And the preferences of their dog
        //Going to implement just one dog as of now, seeing two dogs is a tad bit more complicated, it can be added in later. Maybe do it so it is filtered per dog??

        protected override async Task OnInitializedAsync()
        {
            ParsedMemberId = Guid.Parse(MemberId);
            User = await _userRepository.GetMemberOnId(ParsedMemberId);
            UserDogFilters = await _dogRepository.GetDogFiltersId(User.Id);
            Dogs = await _dogRepository.GetAllDogsExceptUsers(User.UserDogRelationshipsId);
            UserFilters = await _profileRepository.GetUserFilters(User.UserProfileId);
            FilteredDogs = Dogs;
            InitialFilter();
        }

        public void InitialFilter()
        {
            //FilteredDogs = Dogs.Where(filter => filter.Personality == UserDogFilters.Preferences).ToList();
        }

        public void FilterOnDog()
        {
            if(DogName == null || DogName == "null")
            {
                FilteredDogs = Dogs;
                return;
            }

            foreach (var dog in UserDogFilters)
            {
                if (dog.DogName == DogName)
                {
                    FilteredDogs = Dogs.Where(filter => filter.Personality.WorksWithBoys == dog.Preferences.WorksWithBoys &&
                     filter.Personality.WorksWithGirls == dog.Preferences.WorksWithGirls && filter.Personality.Timid == dog.Preferences.Timid &&
                     filter.Personality.Confident == dog.Preferences.Confident && filter.Personality.Adaptable == dog.Preferences.Adaptable &&
                     filter.Personality.Independent == dog.Preferences.Independent && filter.Personality.LaidBack == dog.Preferences.LaidBack
                    ).ToList();
                    break;
                }
            }            
        }
    }
}
