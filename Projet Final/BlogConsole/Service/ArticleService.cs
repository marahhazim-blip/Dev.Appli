using BlogConsole.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogConsole.Service
{
    internal class ArticleService
        {
            private List<Article> articles = new();
            private int nextId = 1;

            public List<Article> GetAll() => articles;

            public Article GetById(int id)
                => articles.FirstOrDefault(a => a.Id == id);

            public void Create(string title, string content)
            {
                articles.Add(new Article
                {
                    Id = nextId++,
                    Title = title,
                    Content = content
                });
            }

            public void Update(int id, string title, string content)
            {
                var article = GetById(id);
                if (article == null) return;

                article.Title = title;
                article.Content = content;
                article.UpdatedAt = System.DateTime.Now;
            }

            public void Delete(int id)
            {
                var article = GetById(id);
                if (article != null)
                    articles.Remove(article);
            }
        }
    }

