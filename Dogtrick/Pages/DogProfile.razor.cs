using Entities;
using Infrastructure.Overviews;
using Infrastructure.Repository;
using Infrastructure.Service.ViewModels;
using Microsoft.AspNetCore.Components;
using System.Security.Permissions;

namespace Dogtrick.Pages
{
    public partial class DogProfile
    {
        [Inject]
        public IDogProfileOverview _dogProfileOverview { get; set; }
        [Inject]
        public NavigationManager _navigationManager { get; set; }

        [Parameter]
        public string DogId { get; set; }
        private Guid ParsedDogId { get; set; }
        
        protected override async Task OnInitializedAsync()
        {
            ParsedDogId = Guid.Parse(DogId);
            _dogProfileOverview.GatherAllInfo(ParsedDogId);
            
        }
    }
}
