using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercice1.Classe
{
    internal class IHMConsoleLivre
    {
        private Repository _repository;

        public IHMConsoleLivre()
        {
            _repository = new Repository();
        }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("\n=== Menu Livre ===");
                Console.WriteLine("1. Ajouter un livre");
                Console.WriteLine("2. Voir tous les livres");
                Console.WriteLine("3. Chercher un livre par ID");
                Console.WriteLine("4. Modifier un livre");
                Console.WriteLine("5. Supprimer un livre");
                Console.WriteLine("0. Quitter");
                Console.Write("\nVotre choix : ");

                string choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        AddLivre();
                        break;
                    case "2":
                        ShowAllLivre();
                        break;
                    case "3":
                        GetById();
                        break;
                    case "4":
                        UpdateLivre();
                        break;
                    case "5":
                        DeleteLivre();
                        break;
                    case "0":
                        Console.WriteLine("Au revoir !");
                        return;
                        break;
                    default:
                        Console.WriteLine("Choix invalide !");
                        break;
                }
            }
        }

        private void AddLivre()
        {
            Console.WriteLine("Ajout d'un Nouveau Livre !!!!");
            Console.WriteLine("Titre : ");
            string titre = Console.ReadLine();
            Console.WriteLine("Auteur : ");
            string auteur = Console.ReadLine();
            Console.WriteLine("Annee de publication : ");
            int annee = int.Parse(Console.ReadLine());
            Console.WriteLine("ISBN : ");
            string isbn = Console.ReadLine();
            Livre livre = new Livre(titre, auteur, annee,isbn);
            _repository.Add(livre);

        }



        private void ShowAllLivre()
        {
            Console.WriteLine("--- Liste des livres ---");
         //  List<Livre> livres = _repository.GetAllBooks();
            foreach (var livre in _repository.GetAllBooks())
            {
                Console.WriteLine(livre);
            }
        }


        private void GetById()
        {

            Console.WriteLine("--- Recherche Par Id ---");
            Console.WriteLine("Id du livre Recherché :");
            var id = int.Parse(Console.ReadLine());
            Livre livre = _repository.GetBookById(id);
            if (livre != null)
            {
                Console.WriteLine(livre);
            }
            else {
                Console.WriteLine("Acun livre avec cette id");
            }
            

        }

        private void UpdateLivre()
        {
            Console.WriteLine("--- Modifier un Livre ---");
            Console.WriteLine("Id du livre a modifier :");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nouveau Titre :");
            var titre = Console.ReadLine();
            Console.WriteLine("Nouveau Auteur :");
            var auteur = Console.ReadLine();
            Console.WriteLine("nouvel Annee de publication :");
            var annee = int.Parse(Console.ReadLine());
            Console.WriteLine("Nouvel ISBN :");
            var isbn = Console.ReadLine();
            _repository.UpdateBook(id,titre, auteur,isbn,annee);


        }


        private void DeleteLivre()
        {
            Console.WriteLine("--- Supprimer un livre ---");
            Console.WriteLine("Id du livre a supprimer :");
            int id = int.Parse(Console.ReadLine());
            _repository.DeleteBook(id);


        }

       
    }
}
