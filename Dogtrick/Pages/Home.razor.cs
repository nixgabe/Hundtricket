using Infrastructure.Repository;
using Microsoft.AspNetCore.Components;

namespace Dogtrick.Pages
{
    public partial class Home
    {
        [Inject]
        NavigationManager NavigationManager { get; set; }
        [Inject]
        IUserRepository _userRepository { get; set; }
        [Parameter]
        public string MemberId { get; set; }
        public string MemberEmail { get; set; }
        private Guid ParsedMemberId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ParsedMemberId = Guid.Parse(MemberId);
            MemberEmail = await _userRepository.GetMemberEmail(ParsedMemberId);
        }

        public async Task GoToProfile()
        {
            NavigationManager.NavigateTo("/Profile");
        }
    }
}
