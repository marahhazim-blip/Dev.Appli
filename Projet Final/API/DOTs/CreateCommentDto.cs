namespace BlogApi.Models.DTOs;

public class CreateCommentDto
{
    public string Author { get; set; } = "Anonyme";
    public string Content { get; set; } = string.Empty;
}
