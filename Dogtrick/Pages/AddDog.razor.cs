using Microsoft.AspNetCore.Components;

namespace Dogtrick.Pages
{
    public partial class AddDog
    {
        [Parameter]
        public string MemberId { get; set; }
        private Guid ParsedMemberId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ParsedMemberId = Guid.Parse(MemberId);

        }
    }
}
