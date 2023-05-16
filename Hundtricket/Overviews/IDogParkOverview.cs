using Entities;
using Infrastructure.Service.ViewModels;

namespace Infrastructure.Overviews
{
    public interface IDogParkOverview
    {
        public User User { get; set; }
        public string DogName { get; set; }
        public List<DogFilterViewModel> UserDogFilters { get; set; }
        public List<DogProfileViewModel> FilteredList { get; set; }
        public void GatherAllInfo(Guid memberId);
        public void FilterDog();
    }
}
