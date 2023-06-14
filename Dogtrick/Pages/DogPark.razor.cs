
using Infrastructure.Overviews;
using Microsoft.AspNetCore.Components;


namespace Dogtrick.Pages
{
    public partial class DogPark
    {
        [Inject]
        public IDogParkOverview _dogParkOverview { get; set; }
        [Inject]
        public NavigationManager _navigationManager { get; set; }

        [Parameter]
        public string MemberId { get; set; }
        private Guid ParsedMemberId { get; set; }
        
        protected override async Task OnInitializedAsync()
        {
            ParsedMemberId = Guid.Parse(MemberId);
            _dogParkOverview.GatherAllInfo(ParsedMemberId);
        }       
        
        public void ViewMemberProfile(Guid profileId)
        {
            string dogId = profileId.ToString();
            _navigationManager.NavigateTo($"/ViewUserProfile/{dogId}");
        }
    }
}
