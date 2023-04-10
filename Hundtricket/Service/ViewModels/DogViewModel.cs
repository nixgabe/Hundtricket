namespace Infrastructure.Service.ViewModels
{
    public class DogViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public Guid PicturesId { get; set; }
        public List<string> Pictures { get; set; }
    }
}
