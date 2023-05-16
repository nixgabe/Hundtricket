using Entities;

namespace Infrastructure.Overviews
{
    public interface IEditProfileOverview
    {
        public User User { get; set; }
        public UserProfile UserProfile { get; set; }
        public List<Gender> Genders { get; set; }

        public void GatherAllInfo(Guid memberId);
        public void SaveChanges();
    }
}
