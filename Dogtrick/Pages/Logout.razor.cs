using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;

namespace Dogtrick.Pages
{
    public partial class Logout
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public AuthenticationStateProvider AuthenticationStateProvider { get; set; }

        [Inject]
        public SignInManager<IdentityUser> SignInManager { get; set; }


        protected override async Task OnInitializedAsync()
        {
            NavigationManager.NavigateTo("/");
        }
    }
}
