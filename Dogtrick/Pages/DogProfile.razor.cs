using Infrastructure.Overviews;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.IO;

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
        private IList<IBrowserFile> files = new List<IBrowserFile>();
        private List<string> Pictures { get; set; }
        public string Picture { get; set; } = string.Empty; 

        protected override async Task OnInitializedAsync()
        {
            ParsedDogId = Guid.Parse(DogId);
            await _dogProfileOverview.GatherAllInfo(ParsedDogId);            
        }
        
        public async void SaveChange(IBrowserFile file)
        {
            files.Add(file);


            //var path = @"C:\Users\nixga\source\repos\Hundtricket\Dogtrick\wwwroot\ProfilePics";
            //await using FileStream fs = new(path, FileMode.Create);
            //await file.OpenReadStream().CopyToAsync(fs);

            Pictures = files.Select(f => f.Name).ToList();
        }

        //private async Task LoadFiles(InputFileChangeEventArgs eventArgs)
        //{
        //    foreach (var file in eventArgs.GetMultipleFiles(1))
        //    {
        //        files.Add(file);
        //        //var path = Path.Combine(Environment.WebRootPath, "Images", file.Name);

        //        byte[] fileContent = new byte[file.Size];
        //        var result = await file.OpenReadStream(file.Size).ReadAsync(fileContent, 0, (Int32)file.Size);

        //        Picture = "data:image/png;base64, " + Convert.ToBase64String(fileContent);
        //    }
        //}
    }
}
