namespace DemoAPIs.Repository.DTOs
{
    public class DogEditRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public string BirthDate { get; set; }
        public string Color { get; set; }
    }
}
