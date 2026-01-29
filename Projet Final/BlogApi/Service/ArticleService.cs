using BlogApi.Data;
using BlogApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogApi.Service
{
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

        public async Task<Article> CreateAsync(Article article)
        {
            _context.Articles.Add(article);
            await _context.SaveChangesAsync();
            return article;
        }

        public async Task<bool> UpdateAsync(int id, Article updated)
        {
            var article = await _context.Articles.FindAsync(id);
            if (article == null) return false;

            article.Title = updated.Title;
            article.Content = updated.Content;
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
}
