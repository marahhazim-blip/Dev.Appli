using BlogApi.Models;
using BlogAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogApi.Data;

public class BlogContext : DbContext
{
    public BlogContext(DbContextOptions<BlogContext> options) : base(options) { }

    public DbSet<Article> Articles => Set<Article>();
    public DbSet<Comment> Comments => Set<Comment>();
}
