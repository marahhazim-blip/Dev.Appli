using BlogConsole.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogConsole.UI
{
    internal class ConsoleMenu

        {
            private ArticleService articleService;
            private CommentService commentService;

            public ConsoleMenu()
            {
                articleService = new ArticleService();
                commentService = new CommentService();
            }

            public void Start()
            {
                int choice;
                do
                {
                Console.WriteLine("\n=== BLOG CONSOLE ===");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("1. Lister les articles");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("2. Créer un article");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("3. Voir un article");
                Console.WriteLine("4. Modifier un article");
                Console.WriteLine("5. Supprimer un article");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("6. Ajouter un commentaire");
                Console.WriteLine("7. Supprimer un commentaire");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("0. Quitter");
                Console.Write("Votre choix : ");

                choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1: ListArticles(); break;
                        case 2: CreateArticle(); break;
                        case 3: ViewArticle(); break;
                        case 4: UpdateArticle(); break;
                        case 5: DeleteArticle(); break;
                        case 6: AddComment(); break;
                        case 7: DeleteComment(); break;
                    }
                } while (choice != 0);
            }

            void ListArticles()
            {
                foreach (var a in articleService.GetAll())
                    Console.WriteLine(a);
            }

            void CreateArticle()
            {
                Console.Write("Titre : ");
                var title = Console.ReadLine();
                Console.Write("Contenu : ");
                var content = Console.ReadLine();
                articleService.Create(title, content);
            }

            void ViewArticle()
            {
                Console.Write("ID : ");
                int id = int.Parse(Console.ReadLine());
                var a = articleService.GetById(id);
                if (a == null) return;

                Console.WriteLine(a.Title);
                Console.WriteLine(a.Content);
                foreach (var c in a.Comments)
                    Console.WriteLine($"- {c}");
            }

            void UpdateArticle()
            {
                Console.Write("ID : ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nouveau titre : ");
                var title = Console.ReadLine();
                Console.Write("Nouveau contenu : ");
                var content = Console.ReadLine();
                articleService.Update(id, title, content);
            }

            void DeleteArticle()
            {
                Console.Write("ID : ");
                articleService.Delete(int.Parse(Console.ReadLine()));
            }

            void AddComment()
            {
                Console.Write("ID article : ");
                int id = int.Parse(Console.ReadLine());
                var article = articleService.GetById(id);
                if (article == null) return;

                Console.Write("Auteur : ");
                var author = Console.ReadLine();
                Console.Write("Commentaire : ");
                var content = Console.ReadLine();
                commentService.AddComment(article, author, content);
            }

            void DeleteComment()
            {
                Console.Write("ID article : ");
                int articleId = int.Parse(Console.ReadLine());
                var article = articleService.GetById(articleId);
                if (article == null) return;

                Console.Write("ID commentaire : ");
                int commentId = int.Parse(Console.ReadLine());
                commentService.DeleteComment(article, commentId);
            }
        }
    }

