using Entities;
using Infrastructure.Repository;
using Infrastructure.Service.ViewModels;

namespace Infrastructure.Overviews
{
    public class DogProfileOverview : IDogProfileOverview
    {
        private readonly IDogRepository _dogRepository;
        private readonly IDogFiltersRepository _dogFiltersRepository;
        private readonly IDogPicturesRepository _dogPicturesRepository;

        public DogProfileOverview(IDogRepository dogRepository, IDogFiltersRepository dogFiltersRepository, IDogPicturesRepository dogPicturesRepository)
        {
            _dogRepository = dogRepository;
            _dogFiltersRepository = dogFiltersRepository;
            _dogPicturesRepository = dogPicturesRepository;
        }

        public Dog Dog { get; set; }
        public DogFilterViewModel DogPreferences { get; set; }
        public AddDogViewModel DogViewModel { get; set; }
        private List<DogPictures> DogPictures { get; set; }
        public bool EditDog { get; set; } = false;

        public async Task GatherAllInfo(Guid dogId)
        {
            Dog = await _dogRepository.GetDogOnId(dogId);
            DogPreferences = await _dogFiltersRepository.GetDogFiltersOnId(Dog);
            DogViewModel = await _dogRepository.FillAddDogviewModelLists();
        }

        public void EditDogButton()
        {
            EditDog = true;
        }

        public async void SaveDogChangesButton(Guid dogId, List<string> pictures)
        {
            _dogRepository.UpdateDog(Dog);
            _dogFiltersRepository.UpdateDogFilters(DogPreferences, dogId);
            
            //Settings to create dogpicturesitems
            //DogPictures = await PrepareDogPictures(pictures);
            //_dogPicturesRepository.UploadPicture(DogPictures);


            EditDog = false;
        }

        public async Task<List<DogPictures>> PrepareDogPictures(List<string> pictures)
        {
            var relationshipId = await _dogPicturesRepository.GetRelationshipsOnId(Dog.DogPicturesRelationshipsId);

            var list = new List<DogPictures>();

            foreach (var pic in pictures)
            {
                DogPictures picture = new DogPictures() 
                {
                     Id = Guid.NewGuid(),
                     DogPicturesId = relationshipId,
                     Photo = pic
                };

                list.Add(picture);
            }
            return list;
        }

    }
}
