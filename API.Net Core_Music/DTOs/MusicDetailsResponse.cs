using DemoAPIs.Exercice02.Entities;
using System.ComponentModel.DataAnnotations;

namespace DemoAPIs.Exercice02.DTOs
{
    public class MusicDetailsResponse
    {
        public int Id { get; set; }
        public string Singer { get; set; }
        public string Title { get; set; }
        public string ReleaseDate { get; set; }
        public string MusicGenre { get; set; }
        public string Duration { get; set; }
        public int Score { get; set; }
    }
}
