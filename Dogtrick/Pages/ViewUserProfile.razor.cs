using Entities;
using Infrastructure.Overviews;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Components;

namespace Dogtrick.Pages
{
    public partial class ViewUserProfile
    {
        [Inject]
        public IViewUserProfileOverview _viewUserProfileOverview { get; set; }
        [Inject]
        public NavigationManager _navigationManager { get; set; }

        [Parameter]
        public string DogId { get; set; }
        private Guid ParsedDogId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ParsedDogId = Guid.Parse(DogId);
            await _viewUserProfileOverview.GatherAllInfo(ParsedDogId);            
        }

        public void NavigateToPrivateMessage()
        {
            _navigationManager.NavigateTo($"/PrivateMessage/{_viewUserProfileOverview.Profile.Id}");
        }
    }
}
