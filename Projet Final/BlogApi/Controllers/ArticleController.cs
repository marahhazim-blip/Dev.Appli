using BlogApi.DTOs;
using BlogApi.Models;
using BlogApi.Service;
using BlogApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers
{
    [ApiController]
    [Route("api/articles")]
    public class ArticlesController : ControllerBase
    {
        private readonly ArticleService _service;

        public ArticlesController(ArticleService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
            => Ok(await _service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var article = await _service.GetByIdAsync(id);
            return article == null ? NotFound() : Ok(article);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateArticleDto dto)
        {
            var article = new Article { Title = dto.Title, Content = dto.Content };
            await _service.CreateAsync(article);
            return CreatedAtAction(nameof(Get), new { id = article.Id }, article);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateArticleDto dto)
        {
            var success = await _service.UpdateAsync(id,
                new Article { Title = dto.Title, Content = dto.Content });

            return success ? NoContent() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
            => await _service.DeleteAsync(id) ? NoContent() : NotFound();
    }
}

