using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace BlogApi.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }

        public List<Comment> Comments { get; set; } = new();
    }
}
