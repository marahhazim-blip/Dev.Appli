using BlogApi.Data;
using BlogApi.Models;
using BlogApi.Models.DTOs;
using BlogAPI.Models;

namespace BlogApi.Services;

public class CommentService
{
    private readonly BlogContext _context;

    public CommentService(BlogContext context)
    {
        _context = context;
    }

    public async Task<Comment> CreateAsync(int articleId, CreateCommentDto dto)
    {
        var comment = new Comment
        {
            ArticleId = articleId,
            Author = dto.Author,
            Content = dto.Content
        };

        _context.Comments.Add(comment);
        await _context.SaveChangesAsync();
        return comment;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var comment = await _context.Comments.FindAsync(id);
        if (comment == null) return false;

        _context.Comments.Remove(comment);
        await _context.SaveChangesAsync();
        return true;
    }
}
