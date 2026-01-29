using BlogApi.Data;
using BlogApi.Models;
using BlogApi.Models.DTOs;
using BlogAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogApi.Services;

public class ArticleService
{
    private readonly BlogContext _context;

    public ArticleService(BlogContext context)
    {
        _context = context;
    }

    public async Task<List<Article>> GetAllAsync()
        => await _context.Articles.Include(a => a.Comments).ToListAsync();

    public async Task<Article?> GetByIdAsync(int id)
        => await _context.Articles.Include(a => a.Comments)
                                  .FirstOrDefaultAsync(a => a.Id == id);

    public async Task<Article> CreateAsync(CreateArticleDto dto)
    {
        var article = new Article
        {
            Title = dto.Title,
            Content = dto.Content
        };

        _context.Articles.Add(article);
        await _context.SaveChangesAsync();
        return article;
    }

    public async Task<bool> UpdateAsync(int id, UpdateArticleDto dto)
    {
        var article = await _context.Articles.FindAsync(id);
        if (article == null) return false;

        article.Title = dto.Title;
        article.Content = dto.Content;
        article.UpdatedAt = DateTime.Now;

        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var article = await _context.Articles.FindAsync(id);
        if (article == null) return false;

        _context.Articles.Remove(article);
        await _context.SaveChangesAsync();
        return true;
    }
}
