namespace Entities
{
    public class DogPreferences
    {
        public Guid Id { get; set; }
        public bool WorksWithBoys { get; set; }
        public bool WorksWithGirls { get; set; }
        public decimal AverageWalk { get; set; } = 0;
        public bool Timid { get; set; }
        public bool Confident { get; set; }
        public bool Adaptable { get; set; }
        public bool Independent { get; set; }
        public bool LaidBack { get; set; }
    }
}
