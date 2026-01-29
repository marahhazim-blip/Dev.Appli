using BlogConsole.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogConsole.Service
{
    internal class CommentService

        {
            private int nextId = 1;

            public void AddComment(Article article, string author, string content)
            {
                article.Comments.Add(new Comment
                {
                    Id = nextId++,
                    ArticleId = article.Id,
                    Author = author,
                    Content = content
                });
            }

            public void DeleteComment(Article article, int commentId)
            {
                var comment = article.Comments.Find(c => c.Id == commentId);
                if (comment != null)
                    article.Comments.Remove(comment);
            }
        }
    }


