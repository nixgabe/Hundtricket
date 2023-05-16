using Entities;

namespace Infrastructure.Overviews
{
    public interface IViewUserProfileOverview
    {
        public User Profile { get; set; }
        public Dog DogProfile { get; set; }

        public void GatherAllInfo(Guid dogId);
    }
}
