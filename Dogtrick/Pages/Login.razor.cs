using Entities;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Dogtrick.Pages
{
    public partial class Login
    {
        public string Email { get; set; }
        public string Password { get; set; }

        [Inject]
        public IUserRepository _userRepository { get; set; }
        [Inject]
        public AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public async Task MemberLogin()
        {
            if (Email != null && Password != null)
            {
                var member = await _userRepository.CheckIfMemberExists(Email);
                if (member.Email == Email && member.Password == Password)
                {
                    HandleLogin(member);
                }
            }
        }

        private async void HandleLogin(User member)
        {
            var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();

            var regClaim = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Role, "Registered", ClaimTypes.Name, Email)
            },
            authenticationType: "True");

            var memberId = member.Id.ToString();
            
            authState.User.AddIdentity(regClaim);
            NavigationManager.NavigateTo($"/Home/{memberId}");
        }
    }
}
