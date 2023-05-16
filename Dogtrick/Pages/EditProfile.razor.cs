using Entities;
using Infrastructure.Overviews;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Components;

namespace Dogtrick.Pages
{
    public partial class EditProfile
    {
        [Inject]
        public IEditProfileOverview _editProfileOverview { get; set; }
        [Inject]
        public NavigationManager _navigationManager { get; set; }

        [Parameter]
        public string MemberId { get; set; }
        private Guid ParsedMemberId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ParsedMemberId = Guid.Parse(MemberId);
            _editProfileOverview.GatherAllInfo(ParsedMemberId);
        }

        public async void SaveChanges()
        {
            _editProfileOverview.SaveChanges();
            _navigationManager.NavigateTo($"/MainProfile/{_editProfileOverview.User.Id}");
        }
    }
}
