using Entities;
using Infrastructure.Repository;
using Infrastructure.Service.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Hundtricket.Pages
{
    partial class Index
    {
        public List<DogViewModel> Dogs { get; set; }

        [Inject]
        public IDogRepository _dogRepository { get; set; }
        [Inject]
        IDogPicturesRepository _dogPicturesRepository { get; set; }


        protected override async Task OnInitializedAsync()
        {
            Dogs = await _dogRepository.GetAllDogs();

            //Not pretty, just a test
            foreach (var dog in Dogs)
            {
                dog.Pictures = await _dogPicturesRepository.GetPicturesOnId(dog.PicturesId);
            }
        }
    }
}
