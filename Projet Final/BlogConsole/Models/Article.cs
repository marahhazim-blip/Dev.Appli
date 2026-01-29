using System;
using System.Collections.Generic;
using System.Text;

namespace BlogConsole.Models
{
    internal class Article
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Content { get; set; }
            public DateTime CreatedAt { get; set; }
            public DateTime? UpdatedAt { get; set; } = DateTime.MinValue;   
            public List<Comment> Comments { get; set; }

            public Article()
            {
                CreatedAt = DateTime.Now;
                Comments = new List<Comment>();
            }

            public override string ToString()
            {
                return $"{Id} - {Title} ({CreatedAt})";
            }
        }
    }
