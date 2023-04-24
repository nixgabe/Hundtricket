using Infrastructure.Repository;
using Infrastructure.Service.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Dogtrick.Pages
{
    public partial class ViewAllDogs
    {
        [Inject]
        public IDogRepository _dogRepository { get; set; }
        [Inject]
        public NavigationManager _navigationManager { get; set; }

        [Parameter]
        public string MemberId { get; set; }
        private Guid ParsedMemberId { get; set; }
        public List<DogViewModel> Dogs { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ParsedMemberId = Guid.Parse(MemberId);
            Dogs = await _dogRepository.GetMemberDogsOnId(ParsedMemberId);
        }

        public void AddDog()
        {
            _navigationManager.NavigateTo($"/AddDog/{MemberId}");
        }

        public void DogProfile(Guid guidDogId)
        {
            var dogId = guidDogId.ToString();
            _navigationManager.NavigateTo($"/DogProfile/{dogId}");
        }
    }
}
