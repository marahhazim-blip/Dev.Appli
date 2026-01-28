using DemoAPIs.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoAPIs.Repository.Data
{
    public class ApplicationDbContext : DbContext
    {

        // Chaque table de notre base de données doit être rendue disponible au niveau de la RAM via un objet de type DbSet<>
        public virtual DbSet<Dog> Dogs { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
