using BlogApi.Data;
using BlogApi.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();



builder.Services.AddDbContext<BlogContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))
    ));

builder.Services.AddScoped<ArticleService>();
builder.Services.AddScoped<CommentService>();

var app = builder.Build();



app.UseAuthorization();
app.MapControllers();
app.Run();
