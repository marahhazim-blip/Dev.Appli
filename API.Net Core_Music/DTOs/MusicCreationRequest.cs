using DemoAPIs.Exercice02.Entities;
using System.ComponentModel.DataAnnotations;

namespace DemoAPIs.Exercice02.DTOs
{
    public class MusicCreationRequest
    {
        public string Singer { get; set; }
        public string Title { get; set; }
        public string ReleaseDate { get; set; }
        public string MusicGenre { get; set; }
        public int Duration { get; set; }
        public int Score { get; set; }
    }
}