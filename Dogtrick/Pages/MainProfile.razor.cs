using Entities;
using Infrastructure.Repository;
using Infrastructure.Service.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Dogtrick.Pages
{
    public partial class MainProfile
    {
        [Inject]
        public IUserRepository _userRepository { get; set; }
        [Inject]
        public IDogRepository _dogRepository { get; set; }
        [Inject]
        public NavigationManager _navigationManager { get; set; }

        [Parameter]
        public string MemberId { get; set; }
        private Guid ParsedMemberId { get; set; }

        public User User { get; set; }
        public List<DogViewModel> Dogs { get; set; }


        protected override async Task OnInitializedAsync()
        {
            ParsedMemberId = Guid.Parse(MemberId);
            User = await _userRepository.GetMemberOnId(ParsedMemberId);
            Dogs = await _dogRepository.GetMemberDogsOnId(ParsedMemberId);
        }

        public void EditProfile()
        {
            _navigationManager.NavigateTo($"/EditProfile/{MemberId}");
        }

        public void AddDog()
        {
            _navigationManager.NavigateTo($"/AddDog/{MemberId}");
        }
    }
}
