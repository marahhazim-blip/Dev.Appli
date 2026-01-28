using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoAPIs.Exercice02.Entities
{
    public class Music
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Singer { get; set; }
        
        [MaxLength(100)]

        public string Title { get; set; }


        public DateOnly ReleaseDate { get; set; }


        public MusicGenre MusicGenre { get; set; }


        public TimeSpan Duration { get; set; }

        public int Score { get; set; }

    }

    public enum MusicGenre
    {
        Unknown,
        Rap,
        Techno,
        Rock,
        Pop,
        Metal,
        Country,
        Reggae,
        Classical,
        K_Pop,
        Jazz,
        Soundtrack,
        R_n_B
    }
}
