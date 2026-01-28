using System.ComponentModel.DataAnnotations;

namespace DemoAPIs.Exercice02.DTOs
{
    public class MusicBasicInfosResponse
    {
        public int Id { get; set; }
        public string Singer { get; set; }
        public string Title { get; set; }
    }
}
