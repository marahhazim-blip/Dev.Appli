using BlogApi.Models.DTOs;
using BlogApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers;

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
        => Ok(await _service.CreateAsync(articleId, dto));

    [HttpDelete("api/comments/{id}")]
    public async Task<IActionResult> Delete(int id)
        => await _service.DeleteAsync(id) ? NoContent() : NotFound();
}
