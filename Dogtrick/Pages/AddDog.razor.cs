using Entities;
using Infrastructure.Overviews;
using Infrastructure.Repository;
using Infrastructure.Service.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Dogtrick.Pages
{
    public partial class AddDog
    {
        [Inject]
        public NavigationManager _navigationManager { get; set; }
        [Inject]
        public IAddDogOverview _addDogOverview { get; set; }

        [Parameter]
        public string MemberId { get; set; }
        public Guid ParsedMemberId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ParsedMemberId = Guid.Parse(MemberId);            
            await _addDogOverview.CreateNewDogTemplates();
        }

        public async void SaveDog()
        {
            _addDogOverview.SaveDog(ParsedMemberId);
            _navigationManager.NavigateTo($"/MainProfile/{MemberId}");
        }
    }
}
