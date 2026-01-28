using DemoAPIs.Exercice02.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoAPIs.Exercice02.Data
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Music> Musics { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
