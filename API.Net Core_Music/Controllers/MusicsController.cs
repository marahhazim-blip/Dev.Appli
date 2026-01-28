using DemoAPIs.Exercice02.Data;
using DemoAPIs.Exercice02.DTOs;
using DemoAPIs.Exercice02.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoAPIs.Exercice02.Controllers
{
    [Route("api/v1/songs")]
    [ApiController]
    public class MusicsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MusicsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll([FromQuery] string? titleStart, [FromQuery] string? singerStart, [FromQuery] int? durationMin)
        {
            if (!string.IsNullOrEmpty(titleStart))
            {
                // Filtre via le début du titre...
                var musicBasicInfosTitle = _context.Musics
                    .Where(music => music.Title.StartsWith(titleStart))
                    .Select(musicTrouve => new MusicBasicInfosResponse()
                    {
                        Id = musicTrouve.Id,
                        Title = musicTrouve.Title,
                        Singer = musicTrouve.Singer
                    })
                    .ToList();

                return Ok(musicBasicInfosTitle);
            }

            if (!string.IsNullOrEmpty(singerStart))
            {
                // Filtre via le début de l'interprête...
                var musicBasicInfosSinger = _context.Musics
                    .Where(music => music.Singer.StartsWith(singerStart))
                    .Select(musicTrouve => new MusicBasicInfosResponse()
                    {
                        Id = musicTrouve.Id,
                        Title = musicTrouve.Title,
                        Singer = musicTrouve.Singer
                    })
                    .ToList();

                return Ok(musicBasicInfosSinger);
            }

            if (durationMin != null & durationMin > 0)
            {
                // Filtre via la durée minimale du morceau...
                var musicBasicInfosDuration = _context.Musics
                    .Where(music => music.Duration.TotalSeconds >= durationMin)
                    .Select(musicTrouve => new MusicBasicInfosResponse()
                    {
                        Id = musicTrouve.Id,
                        Title = musicTrouve.Title,
                        Singer = musicTrouve.Singer
                    })
                    .ToList();

                return Ok(musicBasicInfosDuration);
            }

            // Si aucun filtre...

            var musicBasicInfos = _context.Musics
                .Select(musicTrouve => new MusicBasicInfosResponse()
                {
                    Id = musicTrouve.Id,
                    Title = musicTrouve.Title,
                    Singer = musicTrouve.Singer
                })
                .ToList();

            return Ok(musicBasicInfos);

        }

        [HttpGet("{songId}")]
        public IActionResult GetById(int songId)
        {
            var musicFound = _context.Musics.FirstOrDefault(music => music.Id == songId);

            if (musicFound != null) {

                var musicFoundDto = new MusicDetailsResponse()
                {
                    Id = musicFound.Id,
                    Title = musicFound.Title,
                    Singer = musicFound.Singer,
                    Score = musicFound.Score,
                    Duration = $"{musicFound.Duration.Hours}:{musicFound.Duration.Minutes}:{musicFound.Duration.Seconds}",
                    MusicGenre = musicFound.MusicGenre.ToString(),
                    ReleaseDate = $"{musicFound.ReleaseDate.Day}/{musicFound.ReleaseDate.Month}/{musicFound.ReleaseDate.Year}"
                };

                return Ok(musicFoundDto);
            } else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult CreateMusic([FromBody] MusicCreationRequest payload)
        {
            try
            {
                if (payload.Score < 1 || payload.Score > 5) throw new Exception("Score must be between 1 and 5!");
                var musicScore = payload.Score;

                var musicTitle = payload.Title;
                var musicSinger = payload.Singer;

                var hours = Math.Floor(payload.Duration / 3_600f);
                var minutes = Math.Floor(payload.Duration - hours * 3_600f) / 60;
                var seconds = Math.Floor(payload.Duration - hours * 3_600f - minutes * 60);

                var musicDuration = new TimeSpan((int)hours, (int)minutes, (int)seconds);

                var musicGenre = (MusicGenre)Enum.Parse(typeof(MusicGenre), payload.MusicGenre);

                var releaseDateArray = payload.ReleaseDate.Split('/');
                var day = int.Parse(releaseDateArray[0]);
                var month = int.Parse(releaseDateArray[1]);
                var year = int.Parse(releaseDateArray[2]);

                var musicReleaseDate = new DateOnly(year, month, day);

                var newMusic = new Music()
                {
                    Title = musicTitle,
                    Singer = musicSinger,
                    MusicGenre = musicGenre,
                    Duration = musicDuration,
                    ReleaseDate = musicReleaseDate,
                    Score = musicScore
                };

                _context.Musics.Add(newMusic);
                _context.SaveChanges();
                return CreatedAtAction(nameof(GetById), new { songId = newMusic.Id }, newMusic);
            } catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }

        [HttpPatch("{songId}")]
        public IActionResult UpdateById(int songId, [FromBody] MusicEditionRequest payload)
        {
            var musicFound = _context.Musics.FirstOrDefault(music => music.Id == songId);
            if (musicFound == null) return NotFound();

            try
            {
                if (payload.Score != null && payload.Score > 0)
                {
                    if (payload.Score < 1 || payload.Score > 5) throw new Exception("Score must be between 1 and 5!");
                    musicFound.Score = (int) payload.Score;
                }

                if (!string.IsNullOrEmpty(payload.Title))
                {
                    musicFound.Title = payload.Title;
                }

                if (!string.IsNullOrEmpty(payload.Singer))
                {
                    musicFound.Singer = payload.Singer;
                }

                if (payload.Duration != null && payload.Duration > 0)
                {
                    var hours = Math.Floor((int) payload.Duration / 3_600f);
                    var minutes = Math.Floor((int) payload.Duration - hours * 3_600f) / 60;
                    var seconds = Math.Floor((int) payload.Duration - hours * 3_600f - minutes * 60);

                    musicFound.Duration = new TimeSpan((int)hours, (int)minutes, (int)seconds);
                }

                if (!string.IsNullOrEmpty(payload.MusicGenre))
                {
                    musicFound.MusicGenre = (MusicGenre)Enum.Parse(typeof(MusicGenre), payload.MusicGenre);
                }

                if (!string.IsNullOrEmpty(payload.ReleaseDate))
                {
                    var releaseDateArray = payload.ReleaseDate.Split('/');
                    var day = int.Parse(releaseDateArray[0]);
                    var month = int.Parse(releaseDateArray[1]);
                    var year = int.Parse(releaseDateArray[2]);

                    musicFound.ReleaseDate = new DateOnly(year, month, day);
                }

                _context.SaveChanges();
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }

        [HttpDelete("{songId}")]
        public IActionResult DeleteById(int songId)
        {
            var musicFound = _context.Musics.FirstOrDefault(music => music.Id == songId);

            if (musicFound != null)
            {
                _context.Musics.Remove(musicFound);
                _context.SaveChanges();
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }

    }
}
