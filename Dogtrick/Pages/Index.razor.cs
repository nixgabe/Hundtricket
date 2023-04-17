using Entities;
using Infrastructure.Repository;
using Infrastructure.Service.ViewModels;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace Dogtrick.Pages
{
    partial class Index
    {
        public List<DogViewModel> Dogs { get; set; }

        public User User { get; set; }
        [Inject]
        public IDogRepository _dogRepository { get; set; }
        [Inject]
        public IDogPicturesRepository _dogPicturesRepository { get; set; }

        [Inject]
        public IUserRepository _userRepository { get; set; }


        protected override async Task OnInitializedAsync()
        {
            Dogs = await _dogRepository.GetAllDogs();
                        
            foreach (var dog in Dogs)
            {
                dog.Pictures = await _dogPicturesRepository.GetPicturesOnId(dog.PicturesId);
            }

            var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();            
        }
    }
}
