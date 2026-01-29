using BlogApi.DTOs;
using BlogApi.Models;
using BlogApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace BlogApi.Controllers
{
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly CommentService _service;

        public CommentsController(CommentService service)
        {
            _service = service;
        }

        [HttpPost("api/articles/{articleId}/comments")]
        public async Task<IActionResult> Create(int articleId, CreateCommentDto dto)
        {
            var comment = new Comment
            {
                ArticleId = articleId,
                Author = dto.Author,
                Content = dto.Content
            };

            await _service.CreateAsync(comment);
            return Created("", comment);
        }

        [HttpDelete("api/comments/{id}")]
        public async Task<IActionResult> Delete(int id)
            => await _service.DeleteAsync(id) ? NoContent() : NotFound();
    }
}
