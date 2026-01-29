using BlogApi.Data;
using BlogApi.Service;
using BlogApi.Services;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// 🔹 Controllers (API REST)
builder.Services.AddControllers();

// 🔹 EF Core + MySQL
builder.Services.AddDbContext<BlogContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

// 🔹 Services métier
builder.Services.AddScoped<ArticleService>();
builder.Services.AddScoped<CommentService>();

var app = builder.Build();

// 🔹 Middlewares
app.UseAuthorization();
app.MapControllers();

app.Run();
